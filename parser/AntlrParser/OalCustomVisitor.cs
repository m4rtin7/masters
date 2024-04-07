using AntlrParser.SeqDiagramObjects;

namespace AntlrParser;

public class OalCustomVisitor: OalBaseVisitor<object>
{
    private Dictionary<string, Lifeline> _lifelines;
    private Dictionary<OalParser.FunctionCallContext, string> _functionCallParent;
    private Dictionary<OalParser.WhileCycleContext, string> _whileCycleParent;
    private Dictionary<OalParser.ForEachContext, string> _forEachParent;
    private Dictionary<OalParser.IfConditionContext, string> _ifConditionParent;
    private Lifeline _fromLifeline;
    private Dictionary<string, string> _instanceToLifeline = new Dictionary<string, string>();
    private List<SeqObject> _seqObjects = new List<SeqObject>();
    private Interaction _interaction;
    private Dictionary<string, List<Lifeline>> _functionCallsToLifelines;

    public OalCustomVisitor(Dictionary<string, Lifeline> lifelines, Lifeline fromLifeline, Interaction interaction, Dictionary<string, List<Lifeline>> functionCallsToLifelines)
    {
        _lifelines = lifelines;
        _fromLifeline = fromLifeline;
        _interaction = interaction;
        _functionCallParent = new Dictionary<OalParser.FunctionCallContext, string>();
        _whileCycleParent = new Dictionary<OalParser.WhileCycleContext, string>();
        _ifConditionParent = new Dictionary<OalParser.IfConditionContext, string>();
        _forEachParent = new Dictionary<OalParser.ForEachContext, string>();
        _functionCallsToLifelines = functionCallsToLifelines;
        
        foreach (var lifelineArray in _functionCallsToLifelines.Values)
        {
            lifelineArray.ForEach((lifeline => _lifelines[lifeline.name] = lifeline));
        }
    }

    public override object VisitInstanceCreation(OalParser.InstanceCreationContext context)
    {
        var instanceName = context.instanceName().GetText();
        var className = context.className().GetText();
        AddLifelineIfDoesntExists(className);
        if (instanceName != null)
        {
            _instanceToLifeline[instanceName] = className;
        }
        

        return base.VisitInstanceCreation(context);
    }

    public override object VisitForEach(OalParser.ForEachContext context)
    {
        var elementName = context.element().GetText();
        var elements = context.elements().GetText();
        var codeLines = context.codeLine();
        
        AddLifelineIfDoesntExists(elementName);
        // var lifeline = _lifelines[elementName];
        _instanceToLifeline[elementName] = elementName;
        
        var opaqueExpression = new OpaqueExpression("for each " + elementName + " in " + elements);
        var interactionConstraint = new InteractionConstraint(opaqueExpression.XmiId);
        var interactionOperand = CreateInteractionOperand(new Ref(interactionConstraint.XmiId));
        
        addCodelinesToParent(codeLines, interactionOperand.XmiId);

        var combinedFragment = CreateCombinedFragment(7, interactionOperand.covered);
        combinedFragment.operand.Add(new Ref(interactionOperand.XmiId));
        interactionOperand.owner = new Ref(combinedFragment.XmiId);

        var parent = getForEachParent(context);
        parent.fragment.Add(new Ref(combinedFragment.XmiId));
        parent.ownedElement.Add(new Ref(combinedFragment.XmiId));

        _seqObjects.Add(interactionConstraint);
        _seqObjects.Add(opaqueExpression);

        return base.VisitForEach(context);
    }

    public override object VisitFunctionCall(OalParser.FunctionCallContext context)
    {
        var functionName = context.functionName().GetText();
        var instanceName = context.instanceName().GetText();
        string? lifelineName = null;
        try
        {
            if (instanceName != "self"){
                lifelineName = _instanceToLifeline[instanceName];
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(String.Format("Instance with name {0} doesn't exist", instanceName));
            throw;
        }

        var functionCall = context.GetText();
        var fromLifeline = GetFromLifeline(functionCall);

        if (fromLifeline == null)
        {
            return base.VisitFunctionCall(context);
        }

        var toLifeline = fromLifeline;
        
        if(lifelineName != null) {
            toLifeline = _lifelines[lifelineName];
        }

        AddInteractionToLifeline(fromLifeline, _interaction);
        AddInteractionToLifeline(toLifeline, _interaction);

        var fromOccurrenceSpecification = CreateOccurrenceSpecification(fromLifeline, _interaction);
        var toOccurrenceSpecification = CreateOccurrenceSpecification(toLifeline, _interaction);

        var parent = getFunctionCallParent(context);

        // Console.WriteLine(parent.XmiId);

        parent.fragment.Add(new Ref(toOccurrenceSpecification.XmiId));
        parent.fragment.Add(new Ref(fromOccurrenceSpecification.XmiId));
        parent.ownedElement.Add(new Ref(toOccurrenceSpecification.XmiId));
        parent.ownedElement.Add(new Ref(fromOccurrenceSpecification.XmiId));

        CreateMessage(functionName,toOccurrenceSpecification, fromOccurrenceSpecification, _interaction);

        return base.VisitFunctionCall(context);
    }

    public override object VisitWhileCycle(OalParser.WhileCycleContext context)
    {
        var condition = context.CONDITION().GetText();
        var codeLines = context.codeLine();
        
        var opaqueExpression = new OpaqueExpression("while " + condition);
        var interactionConstraint = new InteractionConstraint(opaqueExpression.XmiId);
        var interactionOperand = CreateInteractionOperand(new Ref(interactionConstraint.XmiId));
        
        addCodelinesToParent(codeLines, interactionOperand.XmiId);

        var combinedFragment = CreateCombinedFragment(7, interactionOperand.covered);
        combinedFragment.operand.Add(new Ref(interactionOperand.XmiId));
        interactionOperand.owner = new Ref(combinedFragment.XmiId);

        var parent = getWhileCycleParent(context);
        parent.fragment.Add(new Ref(combinedFragment.XmiId));
        parent.ownedElement.Add(new Ref(combinedFragment.XmiId));

        // var parentRef = new Ref(parent.XmiId);
        // combinedFragment.enclosingInteraction = parentRef;
        // combinedFragment.owner = parentRef;

        _seqObjects.Add(interactionConstraint);
        _seqObjects.Add(opaqueExpression);
        return base.VisitWhileCycle(context);
    }

    public override object VisitParallel(OalParser.ParallelContext context)
    {
        var combinedFragment = CreateCombinedFragment(5, new HashSet<Ref>());
        combinedFragment.covered =  _lifelines.Values.Select((lifeline => new Ref(lifeline.XmiId))).ToHashSet();

        var threads = context.thread();
        foreach (var thread in threads)
        {
            var threadOpaqueExpression = new OpaqueExpression("");
            var threadInteractionConstraint = new InteractionConstraint(threadOpaqueExpression.XmiId);
            var threadInteractionOperand = CreateInteractionOperand(new Ref(threadInteractionConstraint.XmiId));

            combinedFragment.operand.Add(new Ref(threadInteractionOperand.XmiId));
            combinedFragment.ownedElement.Add(new Ref(threadInteractionOperand.XmiId));
            
            addCodelinesToParent(thread.codeLine(), threadInteractionOperand.XmiId);

            threadInteractionOperand.owner = new Ref(combinedFragment.XmiId);
            
            _seqObjects.Add(threadInteractionConstraint);
            _seqObjects.Add(threadOpaqueExpression);
        }
        
        
        return base.VisitParallel(context);
    }

    public override object VisitIfCondition(OalParser.IfConditionContext context)
    {
        var condition = context.CONDITION().GetText();
        var codeLines = context.codeLine();
        
        var opaqueExpression = new OpaqueExpression("if " + condition);
        var interactionConstraint = new InteractionConstraint(opaqueExpression.XmiId);
        var interactionOperand = CreateInteractionOperand(new Ref(interactionConstraint.XmiId));

        addCodelinesToParent(codeLines, interactionOperand.XmiId);

        var combinedFragment = CreateCombinedFragment(2, interactionOperand.covered);
        combinedFragment.operand.Add(new Ref(interactionOperand.XmiId));
        interactionOperand.owner = new Ref(combinedFragment.XmiId);
        
        var parent = getIfConditionParent(context);
        parent.fragment.Add(new Ref(combinedFragment.XmiId));
        parent.ownedElement.Add(new Ref(combinedFragment.XmiId));

        foreach (var ifElseContext in context.ifElseCondition())
        {
            var ifElseOpaqueExpression = new OpaqueExpression("else if " + ifElseContext.CONDITION().GetText());
            var ifElseInteractionConstraint = new InteractionConstraint(ifElseOpaqueExpression.XmiId);
            var ifElseInteractionOperand = CreateInteractionOperand(new Ref(ifElseInteractionConstraint.XmiId));
            combinedFragment.operand.Add(new Ref(ifElseInteractionOperand.XmiId));
            combinedFragment.ownedElement.Add(new Ref(ifElseInteractionOperand.XmiId));
            
            addCodelinesToParent(ifElseContext.codeLine(), ifElseInteractionOperand.XmiId);
            
            ifElseInteractionOperand.owner = new Ref(combinedFragment.XmiId);

            _seqObjects.Add(ifElseInteractionConstraint);
            _seqObjects.Add(ifElseOpaqueExpression);
        }

        var elseContext = context.elseCondition();
        if (elseContext != null)
        {
            var elseOpaqueExpression = new OpaqueExpression("else");
            var elseInteractionConstraint = new InteractionConstraint(elseOpaqueExpression.XmiId);
            var elseInteractionOperand = CreateInteractionOperand(new Ref(elseInteractionConstraint.XmiId));
            combinedFragment.operand.Add(new Ref(elseInteractionOperand.XmiId));
            combinedFragment.ownedElement.Add(new Ref(elseInteractionOperand.XmiId));
            
            addCodelinesToParent(elseContext.codeLine(), elseInteractionOperand.XmiId);
            
            elseInteractionOperand.owner = new Ref(combinedFragment.XmiId);
            
            _seqObjects.Add(elseInteractionConstraint);
            _seqObjects.Add(elseOpaqueExpression);
        }

        _seqObjects.Add(interactionConstraint);
        _seqObjects.Add(opaqueExpression);

        return base.VisitIfCondition(context);
    }

    private void AddLifelineIfDoesntExists(string lifelineName)
    {
        Console.WriteLine(lifelineName);
        if (!_lifelines.ContainsKey(lifelineName))
        {
            _lifelines.Add(lifelineName, new Lifeline(lifelineName));
        }
    }

    private void AddInteractionToLifeline(Lifeline lifeline, Interaction interaction)
    {
        Console.WriteLine("XXXX");
        var interactionRef = new Ref(interaction.XmiId);
        var lifelineRef = new Ref(lifeline.XmiId);
        
        lifeline.owner = interactionRef;
        lifeline.coveredBy.Add(interactionRef);
        lifeline.interaction = interactionRef;
        interaction.lifeline.Add(lifelineRef);
        interaction.covered.Add(lifelineRef);
        interaction.ownedElement.Add(lifelineRef);
    }

    private InteractionOperand CreateInteractionOperand(Ref guard )
    {
        var interactionOperand = new InteractionOperand();
        interactionOperand.guard = guard;
        interactionOperand.enclosingInteraction = new Ref(_interaction.XmiId);
        var covered = _lifelines.Values.Select((lifeline => new Ref(lifeline.XmiId))).ToHashSet();
        interactionOperand.covered = covered;

        var occurrenceSpecs = _lifelines.Values.Select((lifeline => CreateOccurrenceSpecification(lifeline, _interaction))).ToList();
        interactionOperand.fragment = occurrenceSpecs.Select(specification => new Ref(specification.XmiId)).ToHashSet();
        interactionOperand.ownedElement = interactionOperand.fragment;

        // var combinedFragment = CreateCombinedFragment(7, covered, new Ref(interactionOperand.XmiId));
        // interactionOperand.owner = new Ref(combinedFragment.XmiId);

        _seqObjects.Add(interactionOperand);
        return interactionOperand;
    }

    private CombinedFragment CreateCombinedFragment(int interactionOperator, HashSet<Ref> covered)
    {
        var combinedFragment = new CombinedFragment();
        var interactionRef = new Ref(_interaction.XmiId);

        combinedFragment.enclosingInteraction = interactionRef;
        combinedFragment.owner = interactionRef;
        combinedFragment.interactionOperator = interactionOperator;
        combinedFragment.covered = covered;

        var operandList = new HashSet<Ref>();
        combinedFragment.operand = operandList;
        combinedFragment.ownedElement = operandList;

        var combinedFragmentRef = new Ref(combinedFragment.XmiId);
        _interaction.fragment.Add(combinedFragmentRef);
        _interaction.ownedElement.Add(combinedFragmentRef);
        
        _seqObjects.Add(combinedFragment);
        
        return combinedFragment;
    }

    private OccurrenceSpecification CreateOccurrenceSpecification(Lifeline lifeline, Interaction interaction)
    {
        var lifelineRef = new Ref(lifeline.XmiId);
        var interactionRef = new Ref(interaction.XmiId);
        var occurrenceSpecification = new OccurrenceSpecification();

        //add to occurrenceSpec params
        occurrenceSpecification.covered.Add(lifelineRef);
        occurrenceSpecification.enclosingInteraction = interactionRef;
        //owner of occurenceSpec is always interaction
        occurrenceSpecification.owner = interactionRef;

        //add to interaction params
        // var occurrenceSpecRef = new Ref(occurrenceSpecification.XmiId);
        // interaction.fragment.Add(occurrenceSpecRef);
        // interaction.ownedElement.Add(occurrenceSpecRef);

        //add to objects
        // _lifelineToOccuranceSpecification.Add(lifeline, occurrenceSpecification);
        _seqObjects.Add(occurrenceSpecification);

        return occurrenceSpecification;
    }

    private void CreateMessage(string name, OccurrenceSpecification toOccurrenceSpecification,
        OccurrenceSpecification fromOccurrenceSpecification, Interaction interaction)
    {
        var toOccurrenceSpecificationRef = new Ref(toOccurrenceSpecification.XmiId);
        var fromOccurrenceSpecificationRef = new Ref(fromOccurrenceSpecification.XmiId);
        var interactionRef = new Ref(interaction.XmiId);

        var message = new Message(name);
        message.sendEvent = fromOccurrenceSpecificationRef;
        message.receiveEvent = toOccurrenceSpecificationRef;
        message.interaction = interactionRef;
        message.owner = interactionRef;

        var messageRef = new Ref(message.XmiId);
        interaction.message.Add(messageRef);
        interaction.ownedElement.Add(messageRef);
        
        _seqObjects.Add(message);
    }

    private SeqObject getFunctionCallParent(OalParser.FunctionCallContext codeLineContext)
    {

        if (_functionCallParent.ContainsKey(codeLineContext))
        {
            var parentId = _functionCallParent[codeLineContext];
            return _seqObjects.Find(o => o.XmiId == parentId);
        }

        return _interaction;
    }
    
    private SeqObject getWhileCycleParent(OalParser.WhileCycleContext whileCycleContext)
    {
        if (_whileCycleParent.ContainsKey(whileCycleContext))
        {
            var parentId = _whileCycleParent[whileCycleContext];
            var parent = _seqObjects.Find(o => o.XmiId == parentId);
            return  parent == null ? _interaction : parent;
        }

        return _interaction;
    }

    private SeqObject getForEachParent(OalParser.ForEachContext forEachContext)
    {
        if (_forEachParent.ContainsKey(forEachContext))
        {
            var parentId = _forEachParent[forEachContext];
            var parent = _seqObjects.Find(o => o.XmiId == parentId);
            return  parent == null ? _interaction : parent;
        }

        return _interaction;
    }
    
    private SeqObject getIfConditionParent(OalParser.IfConditionContext ifConditionContext)
    {
        if (_ifConditionParent.ContainsKey(ifConditionContext))
        {
            var parentId = _ifConditionParent[ifConditionContext];
            var parent = _seqObjects.Find(o => o.XmiId == parentId);
            return  parent == null ? _interaction : parent;
        }

        return _interaction;
    }

    private void addCodelinesToParent(OalParser.CodeLineContext[] codeLineContexts, String parentId)
    {
        foreach (var codeLineContext in codeLineContexts)
        {
            var functionCall = codeLineContext.functionCall();
            var ifCondition = codeLineContext.ifCondition();
            var whileCycle = codeLineContext.whileCycle();
            var forEach = codeLineContext.forEach();

            if(functionCall != null) _functionCallParent[functionCall] = parentId;
            if(ifCondition != null) _ifConditionParent[ifCondition] = parentId;
            if(whileCycle != null) _whileCycleParent[whileCycle] = parentId;
            if(forEach != null) _forEachParent[forEach] = parentId;

        }
        
    }

    private Lifeline? GetFromLifeline(string functionCall)
    {
        // Console.WriteLine(functionCall);
        var lifelines = _functionCallsToLifelines[functionCall];
        if (lifelines.Count < 1)
        {
            return null;
        }
        var lifeline = lifelines[0];
        lifelines.RemoveAt(0);
        _functionCallsToLifelines[functionCall] = lifelines;

        return lifeline;
    }

    public List<SeqObject> GetSeqObjects()
    {
        return _seqObjects;
    }
}