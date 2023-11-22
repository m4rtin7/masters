namespace AntlrParser.SeqDiagramObjects;

public class SeqObject
{
    public string XmiId { get; set; }
    public List<Ref> fragment { get; set; }
    public List<Ref> ownedElement { get; set; }

    public SeqObject()
    {
        fragment = new List<Ref>();
        ownedElement = new List<Ref>();
    }
}