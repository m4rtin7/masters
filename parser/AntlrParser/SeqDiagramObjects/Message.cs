namespace AntlrParser.SeqDiagramObjects;

public class Message: SeqObject
{
    public string name { get; set; }
    public string XmiId;
    public string XmiType = "uml:Message";
    public int messageKind_ = 0;
    public int messageSort = 0;
    public Ref receiveEvent { get; set; }
    public Ref sendEvent { get; set; }
    public Ref interaction { get; set; }
    public Ref owner { get; set; }

    public Message(string _name)
    {
        name = _name;
        XmiId = Guid.NewGuid().ToString();
    }
}