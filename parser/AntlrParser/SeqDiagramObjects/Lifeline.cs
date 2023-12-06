using AntlrParser.Helpers;

namespace AntlrParser.SeqDiagramObjects;

public class Lifeline: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public HashSet<Ref> coveredBy { get; set; }
    public Ref? interaction { get; set; }
    public Ref? owner { get; set; }

    public Lifeline(string _name)
    {
        name = _name;
        XmiId = "Lifeline__"+IdGenerator.instance.getId();
        coveredBy = new HashSet<Ref>();
        XmiType = "uml:Lifeline";
    }
}