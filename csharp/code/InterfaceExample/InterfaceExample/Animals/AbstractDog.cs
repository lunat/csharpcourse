namespace InterfaceExample.Animals;
using static System.Console;

public abstract class AbstractDog : IWalkable, ISpeakable
{
    public int Legs { get; set; }
    public abstract bool Jump(int meters);
    public void Walk()
    {
        WriteLine($"The dog is walking with {Legs} legs");
    }
    public virtual void Say()
    {
        WriteLine($"The dog is barking");
    }

    protected void Catch()
    {
        WriteLine($"The dog is catching the ball");
    }
}

public class Labrador : AbstractDog, ICatchable
{
    public override bool Jump(int meters)
    {
        base.Say();
        base.Walk();
        return meters < 10;
    }

    public bool CatchTheBall()
    {
        base.Catch();
        return true;
    }
}

public class Chihuahua : AbstractDog, ICatchable
{
    public override void Say()
    {
        WriteLine($"The Chihuahua is squeaking");
    }
    public override bool Jump(int meters)
    {
        this.Say();
        base.Walk();
        return meters < 1;
    }
    public bool CatchTheBall()
    {
        return false;
    }
}