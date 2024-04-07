using AntlrParser.SeqDiagramObjects;

namespace AntlrParser;
using AntlrParser.AnimationObjects;
using Antlr4.Runtime;

public class OalCustomPreVisitor: OalBaseVisitor<object>
{
    private string _code;
    private List<MethodCode> _methodCodes;
    private Dictionary<string, string> _instanceToClass;
    private Dictionary<string, List<Lifeline>> _functionCallToLifeline;
    private HashSet<string> _alreadyReplaced = new HashSet<string>();
    private Lifeline _lifeline;
    private List<Lifeline> _lifelines;

    public OalCustomPreVisitor(string code, List<MethodCode> methodCodes, string className, Dictionary<string, List<Lifeline>> functionCallToLifeline, List<Lifeline> lifelines)
    {
        _code = code;
        _methodCodes = methodCodes;
        _instanceToClass = new Dictionary<string, string>();
        _instanceToClass["self"] = className;
        _functionCallToLifeline = functionCallToLifeline;
        _lifelines = lifelines;
        var currentLifeline = lifelines.Find((lifeline => lifeline.name == className));
        if (currentLifeline == null)
        {
            var newLifeline = new Lifeline(className);
            _lifeline = newLifeline;
            _lifelines.Add(newLifeline);
        }else
        {
            _lifeline = currentLifeline;
        }
        // _className = className;
    }

    public override object VisitInstanceCreation(OalParser.InstanceCreationContext context)
    {
        var instanceName = context.instanceName().GetText();
        var className = context.className().GetText();

        _instanceToClass[instanceName] = className;
        
        return base.VisitInstanceCreation(context);
    }

    public override object VisitFunctionCall(OalParser.FunctionCallContext context)
    {
        
        string funCall = context.GetText();
       
        AddLifelineToFunCall(funCall, _lifeline);
        
        string instanceName = context.instanceName().GetText();
        var functionName = context.functionName().GetText();
        var className = "";
        try
        {
            className = _instanceToClass[instanceName];

        }
        catch
        { 
            return base.VisitFunctionCall(context);
        }

        var functionCode = GetFunctionCode(className, functionName);

        var visitor = new OalCustomPreVisitor(functionCode, _methodCodes, className, _functionCallToLifeline, _lifelines);
        
        var inputStream = new AntlrInputStream(functionCode);
        var speakLexer = new OalLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(speakLexer);
                
        var oalParser = new OalParser(commonTokenStream);
        var c = oalParser.json();
        visitor.Visit(c);
        
        var replacement = visitor.GetCode();
        // if (funCall == "humanwarrior_1.HumanWarrior();")
        // {
        //     Console.WriteLine("HERE "+ replacement);
        // }
        // ReplaceFirstOccurrence(_code, funCall, funCall + replacement);
        if (_alreadyReplaced.Contains(funCall))
        {
            return base.VisitFunctionCall(context);
        }

        _alreadyReplaced.Add(funCall);
        _code = _code.Replace(funCall, funCall + replacement);
        return base.VisitFunctionCall(context);
    }

    private string GetFunctionCode(string className, string functionName)
    {
        var methodCde = _methodCodes.Find((code => code.Name == className));
        if (methodCde == null)
        {
            return "";
        }

        var method = methodCde.Methods.Find((method => method.Name == functionName));

        if (method == null)
        {
            return "";
        }
        return method.Code;
    }

    public string GetCode()
    {
        // Console.WriteLine("=====\n" + _className  + "\n" + _code + "\n=====\n" );
        return _code;
    }

    public Dictionary<string, List<Lifeline>> GetFunctionCallToLifeline()
    {
        return _functionCallToLifeline;
    }

    private void AddLifelineToFunCall(string funCall, Lifeline lifeline)
    {
        try
        {
            _functionCallToLifeline[funCall].Add(lifeline);
        }
        catch
        {
            var value = new List<Lifeline>();
            value.Add(lifeline);
            _functionCallToLifeline[funCall] = value;
        }
    }
    
    public static string ReplaceFirstOccurrence(string source, string find, string replace)
    {
        int place = source.IndexOf(find);
    
        if (place == -1)
            return source;
    
        return source.Remove(place, find.Length).Insert(place, replace);
    }
}