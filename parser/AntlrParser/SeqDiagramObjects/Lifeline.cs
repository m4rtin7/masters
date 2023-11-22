namespace AntlrParser.SeqDiagramObjects;

public class Lifeline: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public List<Ref> coveredBy { get; set; }
    public Ref? interaction { get; set; }
    public Ref? owner { get; set; }

    public Lifeline(string _name)
    {
        name = _name;
        XmiId = Guid.NewGuid().ToString();
        coveredBy = new List<Ref>();
        XmiType = "uml:Lifeline";
    }
}