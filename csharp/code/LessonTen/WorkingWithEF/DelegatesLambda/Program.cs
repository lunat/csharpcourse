using System.ComponentModel;

Action<string, string> Greetings = (name, surname) =>
{
    var greeting = $"Hello {name} {surname}";
    Console.WriteLine(greeting);
};

Func<int, double, int> SquareFake = (x, y) => x * x;
Func<int, string> SquareToString = x => (x * x).ToString();

Func<int, int> Square = (x) =>
{
    return x * x;
};
Func<int, int> Sum = (x) =>
{
    return x + x;
};
Func<int, int> Power = (x) =>
{
    return (int)Math.Pow(x, x);
};

Dictionary<Type, Func<int, int>> myDictionary
    = new Dictionary<Type, Func<int, int>>();
myDictionary.Add(typeof(int), Power);
myDictionary.Add(typeof(double), Sum);
myDictionary.Add(typeof(string), Square);

Type exp = 3.GetType();
int myParamenter = 4;
switch (exp.ToString())
{
    case "System.Int32":
        Console.WriteLine((int)Math.Pow(myParamenter, myParamenter));
        break;
    case "System.Double":
        Console.WriteLine(myParamenter + myParamenter);
        break;
    case "System.String":
        Console.WriteLine(myParamenter * myParamenter);
        break;
    default:
        Console.WriteLine("Error");
        break;
}

if (!myDictionary.ContainsKey(exp))
    Console.WriteLine("Error");
else
    Console.WriteLine(myDictionary[exp].Invoke(myParamenter));



Greetings("Luca", "Natali");
Console.WriteLine(Square(5));
Console.WriteLine(SquareToString(4));

// Dictionary initialization
var myD = new Dictionary<string, string>();
myD.Add("primo", "Uno");
myD.Add("secondo", "Due");
myD.Add("terzo", "Tre");

// Dictionary foreach
foreach (var item in myD)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

// Dictionary single element
Console.WriteLine($"{myD["terzo"]}");
// exception Console.WriteLine($"{myD["quarto"]}");

var myList = new List<string>
{
    "primo",
    "secondo",
    "terzo",
    "quarto"
};

var res = myList
    .Where(text => text.Length < 7)
    .OrderBy(text => text.Length)
    .ThenBy(text => text);



