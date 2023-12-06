namespace AntlrParser.SeqDiagramObjects;

public class Ref
{
    public string XmiIdRef { get; set; }

    public Ref(string xmiIdRef)
    {
        XmiIdRef = xmiIdRef;
    }

    public override bool Equals(object? obj)
    {
        Ref other = obj as Ref;
        return other.XmiIdRef == this.XmiIdRef;
    }

    public override int GetHashCode()
    {
        return this.XmiIdRef.GetHashCode();
    }
}