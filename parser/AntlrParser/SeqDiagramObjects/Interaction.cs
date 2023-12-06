using AntlrParser.Helpers;

namespace AntlrParser.SeqDiagramObjects;

public class Interaction: SeqObject
{
    public string name = "";
    public string XmiType = "uml:Interaction";
    public HashSet<Ref> lifeline { get; set; }
    public HashSet<Ref> message { get; set; }
    public HashSet<Ref> covered { get; set; }

    public Interaction()
    {
        XmiId = "Interaction__"+IdGenerator.instance.getId();;
        lifeline = new HashSet<Ref>();
        message = new HashSet<Ref>();
        covered = new HashSet<Ref>();
    }
}