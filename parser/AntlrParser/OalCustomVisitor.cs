using AntlrParser.SeqDiagramObjects;

namespace AntlrParser;

public class OalCustomVisitor: OalBaseVisitor<object>
{
    private Dictionary<string, Lifeline> _lifelines;
    private Lifeline _fromLifeline;
    private Dictionary<string, string> _instanceToLifeline = new Dictionary<string, string>();
    private List<SeqObject> _seqObjects = new List<SeqObject>();
    private Interaction _interaction;

    public OalCustomVisitor(Dictionary<string, Lifeline> lifelines, Lifeline fromLifeline, Interaction interaction)
    {
        _lifelines = lifelines;
        _fromLifeline = fromLifeline;
        _interaction = interaction;
    }

    public override object VisitInstanceCreation(OalParser.InstanceCreationContext context)
    {
        var instanceName = context.instanceName().GetText();
        var className = context.className().GetText();
        AddLifelineIfDoesntExists(className);
        if (instanceName != null)
        {
            _instanceToLifeline.Add(instanceName, className);
        }
        

        return base.VisitInstanceCreation(context);
    }

    public override object VisitFunctionCall(OalParser.FunctionCallContext context)
    {
        var functionName = context.functionName().GetText();
        var instanceName = context.instanceName().GetText();
        var lifelineName = "";
        try
        {
            lifelineName = _instanceToLifeline[instanceName];
        }
        catch (Exception e)
        {
            Console.WriteLine(String.Format("Instance with name {0} doesn't exist", instanceName));
            throw;
        }

        var toLifeline = _lifelines[lifelineName];

        AddInteractionToLifeline(_fromLifeline, _interaction);
        AddInteractionToLifeline(toLifeline, _interaction);

        var fromOccurrenceSpecification = CreateOccurrenceSpecification(_fromLifeline, _interaction);
        var toOccurrenceSpecification = CreateOccurrenceSpecification(toLifeline, _interaction);

        CreateMessage(functionName,toOccurrenceSpecification, fromOccurrenceSpecification, _interaction);

        return base.VisitFunctionCall(context);
    }

    public override object VisitWhileCycle(OalParser.WhileCycleContext context)
    {
        var statement = context.STATEMENT().GetText();
        var functionCalls = context.functionCall();
        var instanceCreations = context.instanceCreation();

        var opaqueExpression = new OpaqueExpression(statement);
        var interactionConstraint = new InteractionConstraint(opaqueExpression.XmiId);
        var interactionOperand = CreateInteractionOperand(new Ref(interactionConstraint.XmiId));

        _seqObjects.Add(interactionConstraint);
        _seqObjects.Add(opaqueExpression);
        return base.VisitWhileCycle(context);
    }

    private void AddLifelineIfDoesntExists(string lifelineName)
    {
        if (!_lifelines.ContainsKey(lifelineName))
        {
            _lifelines.Add(lifelineName, new Lifeline(lifelineName));
        }
    }

    private void AddInteractionToLifeline(Lifeline lifeline, Interaction interaction)
    {
        var interactionRef = new Ref(interaction.XmiId);
        var lifelineRef = new Ref(lifeline.XmiId);
        lifeline.owner = interactionRef;
        lifeline.coveredBy.Add(interactionRef);
        lifeline.interaction = interactionRef;
        interaction.lifeline.Add(lifelineRef);
        interaction.covered.Add(lifelineRef);
        interaction.ownedElement.Add(lifelineRef);
    }

    private InteractionOperand CreateInteractionOperand(Ref _guard )
    {
        var interactionOperand = new InteractionOperand();
        interactionOperand.guard = _guard;
        interactionOperand.enclosingInteraction = new Ref(_interaction.XmiId);
        
        _seqObjects.Add(interactionOperand);
        return interactionOperand;
    } 

    private OccurrenceSpecification CreateOccurrenceSpecification(Lifeline lifeline, Interaction interaction)
    {
        var lifelineRef = new Ref(lifeline.XmiId);
        var interactionRef = new Ref(interaction.XmiId);
        var occurrenceSpecification = new OccurrenceSpecification();
        
        //add to occurrenceSpec params
        occurrenceSpecification.covered.Add(lifelineRef);
        occurrenceSpecification.enclosingInteraction = interactionRef;
        occurrenceSpecification.owner = interactionRef;

        //add to interaction params
        var occurrenceSpecRef = new Ref(occurrenceSpecification.XmiId);
        interaction.fragment.Add(occurrenceSpecRef);
        interaction.ownedElement.Add(occurrenceSpecRef);
        
        //add to objects
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

    public List<SeqObject> GetSeqObjects()
    {
        return _seqObjects;
    }
}