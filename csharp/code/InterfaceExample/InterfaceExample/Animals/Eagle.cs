namespace InterfaceExample.Animals;
using static System.Console;

public class Eagle : IFlyable, IWalkable, ISpeakable
{
    public int Wings { get; set; }
    public int Legs { get; set; }

    public void Walk()
    {
        WriteLine($"The eagle is walking with {Legs} legs");
    }
    public void Fly()
    {
        WriteLine($"The eagle is flying with {Wings} wings");
    }

    public void Say()
    {
        WriteLine($"The eagle is saying something");
    }
}