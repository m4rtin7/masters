using AntlrParser.Helpers;

namespace AntlrParser.SeqDiagramObjects;

public class InteractionConstraint: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public Ref specification;

    public InteractionConstraint(string _ref)
    {
        name = "";
        XmiId = "InteractionConstraint__"+IdGenerator.instance.getId();
        XmiType = "uml:InteractionConstraint";
        specification = new Ref(_ref);
    }
}