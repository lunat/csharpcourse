using static System.Console;
namespace Shared;

public class Person : object, IComparable<Person>
{
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    public virtual void Sing()
    {
        WriteLine($"{Name} is singing!");
    }

    //static method
    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    //instance method
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    //operator
    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1, p2);
    }

    public int MyMethod(string input)
    {
        return input.Length;
    }

    //--------------------------
    //delegate field
    public event EventHandler? Shout;
    //data field
    public int AngerLevel;

    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // if something is listening..
            //if (Shout != null)
            //{
            //    //then shout
            //    Shout(this, EventArgs.Empty);
            //}

            Shout?.Invoke(this, EventArgs.Empty);
        }
    }


    public int CompareTo(Person? other)
    {
        if (Name is null) return ("").CompareTo(other?.Name);
        return Name.CompareTo(other?.Name);
    }

    public void TimeTravel(DateTime when)
    {
        if (when <= DateOfBirth)
        {
            throw new PersonException("You cannot travel so far!");
        }

        WriteLine($"Welcome to {when:yyyy}");
    }
}
