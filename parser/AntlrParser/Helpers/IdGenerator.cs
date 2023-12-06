namespace AntlrParser.Helpers;

public sealed class IdGenerator
{
    private static IdGenerator _instance = null;
    private static readonly object padlock = new object();
    private int id = 1;

    IdGenerator()
    {
    }

    public static IdGenerator instance
    {
        get
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new IdGenerator();
                }

                return _instance;
            }
        }
    }

    public string getId()
    {
        var rv = id;
        id++;
        return rv.ToString();
    }

}