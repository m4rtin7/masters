using Antlr4.Runtime;
using AntlrParser;
using AntlrParser.AnimationObjects;
using AntlrParser.SeqDiagramObjects;
using Json.Net;

// using (StreamReader r = new StreamReader("animationBasic.json"))
// using (StreamReader r = new StreamReader("nestedIf.json"))
// using (StreamReader r = new StreamReader("chain.json")) 
// using (StreamReader r = new StreamReader("forEach.json"))
// using (StreamReader r = new StreamReader("animation.json"))
// using (StreamReader r = new StreamReader("fowler.json"))
// using (StreamReader r = new StreamReader("basicForEach.json"))
// using (StreamReader r = new StreamReader("mediator.json"))
// using (StreamReader r = new StreamReader("absFactory.json"))
using (StreamReader r = new StreamReader("absFactoryPara.json"))
// using (StreamReader r = new StreamReader("ChainOfResponsibility.json"))
// using (StreamReader r = new StreamReader("Observer-vac.json"))

{
    Dictionary<string, Lifeline> lifelines= new Dictionary<string,Lifeline>();
    Interaction interaction = new Interaction();
    List<SeqObject> objects = new List<SeqObject>();
    objects.Add(interaction);
    
    string json = r.ReadToEnd();
    Animation animation = JsonNet.Deserialize<Animation>(json);

    var code = "";
    var startName = "";
    foreach (var methodCode in animation.MethodsCodes)
    {
        var startClass = methodCode.Methods.Find((method => method.Name == animation.StartMethod));
        if (startClass != null)
        {
            code = startClass.Code;
            startName = methodCode.Name;
            break;
        }
    }
    
    var v = new OalCustomPreVisitor(code, animation.MethodsCodes, startName, new Dictionary<string, List<Lifeline>>(), new List<Lifeline>());
    var inputStreamV = new AntlrInputStream(code);
    var speakLexerV = new OalLexer(inputStreamV);
    var commonTokenStreamV = new CommonTokenStream(speakLexerV);
        
    var oalParserV = new OalParser(commonTokenStreamV);
    var contextV = oalParserV.json();
    v.Visit(contextV);
    var parsedCode = v.GetCode();
    var functionCallsToLifelines = v.GetFunctionCallToLifeline();
    // foreach (var methodCode in animation.MethodsCodes)
    // {
    if (!lifelines.ContainsKey(startName))
    {
        lifelines.Add(startName, new Lifeline(startName));
            
    }
    
    
    var fromLifeline = lifelines[startName];
    var inputStream = new AntlrInputStream(parsedCode);
    var speakLexer = new OalLexer(inputStream);
    var commonTokenStream = new CommonTokenStream(speakLexer);
    File.WriteAllText("xxx.json", JsonNet.Serialize(parsedCode));

    var oalParser = new OalParser(commonTokenStream);
    var context = oalParser.json();
    Console.WriteLine("lifelinse count:" + interaction.lifeline.Count);
    var visitor = new OalCustomVisitor(lifelines, fromLifeline, interaction, functionCallsToLifelines);
    visitor.Visit(context);
    Console.WriteLine(objects.Count);
    objects = objects.Concat(visitor.GetSeqObjects()).ToList();
    //     }
    // }
    //
    Console.WriteLine("lifelinse count:" + lifelines.Count);
    objects = objects.Concat(lifelines.Values).ToList();
    File.WriteAllText("seq.json", JsonNet.Serialize(objects));
    
    

}