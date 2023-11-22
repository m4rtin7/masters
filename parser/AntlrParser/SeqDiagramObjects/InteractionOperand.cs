using AntlrParser.SeqDiagramObjects;

public class InteractionOperand: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public List<Ref> fragment { get; set; }
    public Ref guard { get; set; }
    public List<Ref> covered { get; set; }
    public Ref owner { get; set; }
    public Ref enclosingInteraction { get; set; }

    public InteractionOperand()
    {
        name = "";
        XmiId = Guid.NewGuid().ToString();
        XmiType = "uml:InteractionOperand";
    }
}