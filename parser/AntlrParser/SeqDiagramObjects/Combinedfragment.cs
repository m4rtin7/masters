using AntlrParser.Helpers;

namespace AntlrParser.SeqDiagramObjects;

public class CombinedFragment: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public int interactionOperator { get; set; }
    public HashSet<Ref> operand { get; set; }
    public HashSet<Ref> covered { get; set; }
    public Ref owner { get; set; }
    public HashSet<Ref> ownedElement { get; set; }
    public Ref enclosingInteraction { get; set; }

    public CombinedFragment()
    {
        name = "";
        XmiId = "CombinedFragment__"+IdGenerator.instance.getId();
        XmiType = "uml:CombinedFragment";
    }
}