namespace AntlrParser.SeqDiagramObjects;

public class Interaction: SeqObject
{
    public string name = "";
    public string XmiId;
    public string XmiType = "uml:Interaction";
    public List<Ref> lifeline { get; set; }
    public List<Ref> message { get; set; }
    public List<Ref> fragment { get; set; }
    public List<Ref> covered { get; set; }
    public List<Ref> ownedElement { get; set; }

    public Interaction()
    {
        XmiId = Guid.NewGuid().ToString();
        lifeline = new List<Ref>();
        message = new List<Ref>();
        fragment = new List<Ref>();
        covered = new List<Ref>();
        ownedElement = new List<Ref>();

    }
}