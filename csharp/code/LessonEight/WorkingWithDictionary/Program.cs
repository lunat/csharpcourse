using static System.Console;

WorkingWithDictionary();

static void WorkingWithDictionary()
{
    Dictionary<string, string> keywords = new();
    keywords.Add(key: "int", value: "32-bit integer data type");
    keywords.Add("long", "64-bit integer data type");
    keywords.Add("float","Single precision floating point number");

    Dictionary<string, string> keywords2 = new()
    {
        { "int", "32-bit integer data type" },
        { "long", "64-bit integer data type" },
        { "float", "Single precision floating point number" },
    };

    Dictionary<string, string> keywords3 = new()
    {
        ["int"] = "32-bit integer data type",
        ["long"] = "64-bit integer data type",
        ["float"] = "Single precision floating point number"
    };

    Output("Dictionary Keys", keywords.Keys);
    Output("Dictionary values", keywords.Values);
    WriteLine("Keywords with their values:");
    foreach (KeyValuePair<string, string> item in keywords)
    {
        WriteLine($"    {item.Key}: {item.Value}");
    }

    string myKey = "long";
    WriteLine($"the definition of {myKey} is {keywords[myKey]}");
}

static void Output(string title, IEnumerable<string> collection)
{
    WriteLine(title);
    foreach (var item in collection)
    {
        WriteLine($"    {item}");
    }
}