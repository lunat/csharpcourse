namespace InterfaceExample.Animals;
using static System.Console;

public class Dolphin : ISwimmable, ISpeakable
{
    public int Fins { get; set; }

    public void Swim()
    {
        WriteLine($"The dolphin is swimming with {Fins} fins");
    }

    public void Say()
    {
        WriteLine($"The dolphin is saying something");
    }
}