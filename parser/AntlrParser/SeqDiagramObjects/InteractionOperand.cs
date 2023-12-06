using AntlrParser.Helpers;
using AntlrParser.SeqDiagramObjects;

public class InteractionOperand: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public HashSet<Ref> fragment { get; set; }
    public Ref guard { get; set; }
    public HashSet<Ref> covered { get; set; }
    public Ref owner { get; set; }
    public Ref enclosingInteraction { get; set; }

    public InteractionOperand()
    {
        name = "";
        XmiId = "InteractionOperand__"+IdGenerator.instance.getId();
        XmiType = "uml:InteractionOperand";
    }
}