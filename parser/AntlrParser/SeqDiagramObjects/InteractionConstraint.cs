namespace AntlrParser.SeqDiagramObjects;

public class InteractionConstraint: SeqObject
{
    public string name { get; set; }
    public string XmiId { get; set; }
    public string XmiType;
    public Ref specification;

    public InteractionConstraint(string _ref)
    {
        name = "";
        XmiId = Guid.NewGuid().ToString();
        XmiType = "uml:InteractionConstraint";
        specification = new Ref(_ref);
    }
}