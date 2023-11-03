namespace AntlrParser.SeqDiagramObjects;

public class CombinedFragment: SeqObject
{
    public string name { get; set; }
    public string XmiId { get; set; }
    public string XmiType;
    public int interactionOperator { get; set; }
    public List<Ref> operand { get; set; }
    public List<Ref> covered { get; set; }
    public Ref owner { get; set; }
    public List<Ref> ownedElement { get; set; }

    public CombinedFragment()
    {
        name = "";
        XmiId = Guid.NewGuid().ToString();
        XmiType = "uml:CombinedFragment";
    }
}