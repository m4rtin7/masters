namespace AntlrParser.Helpers;

public sealed class OpaqueExpressionGenerator
{
    private static OpaqueExpressionGenerator _instance = null;
    private static readonly object padlock = new object();
    private static Dictionary<string,  List<string>> parentChildsMap;
    private string? master;

    OpaqueExpressionGenerator()
    {
        parentChildsMap = new Dictionary<string, List<string>>();
    }

    public static OpaqueExpressionGenerator instance
    {
        get
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new OpaqueExpressionGenerator();
                }

                return _instance;
            }
        }
    }

    private string getKey(string classN, string functionN)
    {
        return classN + "_" + functionN;
    }

    public void AddChildToParent(string childClass, string childFunctionName, string parentClass, string parentFunctionName)
    {
        var childKey = getKey(childClass, childFunctionName);
        var parentKey = getKey(parentClass, parentFunctionName);

        master ??= parentKey;
        
        var currentChilds = new List<string>();
        parentChildsMap.TryGetValue(parentKey, out currentChilds);

        currentChilds ??= new List<string>();
        
        currentChilds.Add(childKey);
        
        parentChildsMap[parentKey] = currentChilds;
    }

    public List<string> GetOrderedClassCalls(string? parentKey)
    {
        if (parentKey == null)
        {
            if (master == null)
            {
                return new List<string>();
            }
            return GetOrderedClassCalls(master);
        }

        var children = parentChildsMap[parentKey];
        var rv = new List<string>(){parentKey};
        
        foreach (var child in children)
        {
            rv.AddRange(GetOrderedClassCalls(child));
        }

        return rv;
    }

}