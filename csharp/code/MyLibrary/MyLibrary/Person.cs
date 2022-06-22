namespace MyLibrary;

public partial class Person : object
{
    // constants
    public const string Species = "Homo Sapiens";

    // read-only fields
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    // fields
    public string Name;
    public DateTime DateofBirth;
    public Wonders FavoritesWonders;
    public List<Person> Children = new();

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    public void Deconstruct(out string name, out DateTime dob)
    {
        name = Name;
        dob = DateofBirth;
    }

    public void Deconstruct(out string name, out DateTime dob, out Wonders favWonders)
    {
        name = Name;
        dob = DateofBirth;
        favWonders = FavoritesWonders;
    }

    public void WriteToConsole()
    {
        Console.WriteLine($"{Name} was born on a {DateofBirth:dddd}");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    public string OptionalParameters(
        string command,
        double number,
        bool active = true)
    {
        return $"Command is {command}, number is {number}, active is {active}";
    }

    public void PassingParameters(int x, ref int y, out int z)
    {
        z = 99;

        x++;
        y++;
        z++;
    }

}
