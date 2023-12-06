using AntlrParser.Helpers;

namespace AntlrParser.SeqDiagramObjects;

public class OccurrenceSpecification: SeqObject
{
    public string name = "";
    public string XmiType = "uml:OccurrenceSpecification";
    public HashSet<Ref> covered { get; set; }
    public Ref enclosingInteraction { get; set; }
    public Ref owner { get; set; }

    public OccurrenceSpecification()
    {
        XmiId = "OccurrenceSpecification__"+IdGenerator.instance.getId();
        covered = new HashSet<Ref>();
    }
}