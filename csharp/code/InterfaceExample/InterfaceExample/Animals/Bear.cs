namespace InterfaceExample.Animals;
using static System.Console;

internal class Bear : IWalkable, ISpeakable
{
    public int Legs { get; set; }

    public void Walk()
    {
        WriteLine($"The bear is walking with {Legs} legs");
    }
    public void Say()
    {
        WriteLine($"The bear is saying something");
    }
}
