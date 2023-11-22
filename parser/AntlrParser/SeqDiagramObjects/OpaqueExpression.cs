namespace AntlrParser.SeqDiagramObjects;

public class OpaqueExpression: SeqObject
{
    public string name { get; set; }
    public string XmiType;
    public string body { get; set; }

    public OpaqueExpression(string _body)
    {
        name = "";
        body = _body;
        XmiId = Guid.NewGuid().ToString();
        XmiType = "uml:OpaqueExpression";
    }
}