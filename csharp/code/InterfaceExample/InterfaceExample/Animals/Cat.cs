namespace InterfaceExample.Animals;
using static System.Console;

public class Cat : IWalkable, ISpeakable
{
    public int Legs { get; set; }

    public void Walk()
    {
        WriteLine($"The cat is walking with {Legs} legs");
    }

    public virtual void Say()
    {
        WriteLine($"The cat is meowing");
    }
}

public class BlackCat : Cat
{
    public string WitchName { get; set; }
    public override void Say()
    {
        base.Say();
        WriteLine($"The Black cat is meowing at {WitchName}");
    }
}