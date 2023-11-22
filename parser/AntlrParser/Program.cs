using Antlr4.Runtime;
using AntlrParser;
using AntlrParser.AnimationObjects;
using AntlrParser.SeqDiagramObjects;
using Json.Net;

using (StreamReader r = new StreamReader("animation.json"))
{
    Dictionary<string, Lifeline> lifelines= new Dictionary<string,Lifeline>();
    Interaction interaction = new Interaction();
    List<SeqObject> objects = new List<SeqObject>();
    objects.Add(interaction);

    string json = r.ReadToEnd();
    Animation animation = JsonNet.Deserialize<Animation>(json);
    foreach (var methodCode in animation.MethodsCodes)
    {
        if (!lifelines.ContainsKey(methodCode.Name))
        {
            lifelines.Add(methodCode.Name, new Lifeline(methodCode.Name));
                
        }
        foreach (var method in methodCode.Methods)
        {

            var fromLifeline = lifelines[methodCode.Name];
            var inputStream = new AntlrInputStream(method.Code);
            var speakLexer = new OalLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(speakLexer);
                
            var oalParser = new OalParser(commonTokenStream);
            var context = oalParser.json();
            var visitor = new OalCustomVisitor(lifelines, fromLifeline, interaction);
            visitor.Visit(context);
            objects = objects.Concat(visitor.GetSeqObjects()).ToList();
        }
    }

    objects = objects.Concat(lifelines.Values).ToList();
    File.WriteAllText("seq.json", JsonNet.Serialize(objects));
    
}