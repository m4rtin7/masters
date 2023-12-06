namespace AntlrParser.SeqDiagramObjects;

public class SeqObject
{
    public string XmiId { get; set; }
    public HashSet<Ref> fragment { get; set; }
    public HashSet<Ref> ownedElement { get; set; }

    public SeqObject()
    {
        fragment = new HashSet<Ref>();
        ownedElement = new HashSet<Ref>();
    }
}