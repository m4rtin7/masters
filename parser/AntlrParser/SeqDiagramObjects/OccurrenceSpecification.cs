namespace AntlrParser.SeqDiagramObjects;

public class OccurrenceSpecification: SeqObject
{
    public string name = "";
    public string XmiId { get; set; }
    public string XmiType = "uml:OccurrenceSpecification";
    public List<Ref> covered { get; set; }
    public Ref enclosingInteraction { get; set; }
    public Ref owner { get; set; }

    public OccurrenceSpecification()
    {
        XmiId = Guid.NewGuid().ToString();
        covered = new List<Ref>();
    }
}