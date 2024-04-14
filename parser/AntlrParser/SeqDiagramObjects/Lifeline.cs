using AntlrParser.Helpers;

namespace AntlrParser.SeqDiagramObjects;

public class Lifeline: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public HashSet<Ref> coveredBy { get; set; }
    public Ref? interaction { get; set; }
    public Ref? owner { get; set; }

    public Lifeline(string _name, Interaction _interaction)
    {
        var interactionRef = new Ref(_interaction.XmiId);
        
        name = _name;
        XmiId = "Lifeline__"+IdGenerator.instance.getId();
        coveredBy = new HashSet<Ref>();
        owner = interactionRef;
        interaction = interactionRef;
        coveredBy = new HashSet<Ref>();
        coveredBy.Add(interactionRef);
        XmiType = "uml:Lifeline";
    }
}