using Shared;
using static System.Console;

namespace LessonSix;

public static class PersonActions
{
    public static void Execute()
    {

        Person harry = new() { Name = "Harry" };
        Person mary = new() { Name = "Mary" };
        Person greta = new() { Name = "Greta" };

        // instance method
        Person baby = mary.ProcreateWith(harry);
        baby.Name = "Tom";

        // static method
        Person baby2 = Person.Procreate(harry, greta);

        //call static operator
        Person baby3 = harry * greta;

        WriteLine($"{harry.Name} has {harry.Children.Count} children");
        WriteLine($"{mary.Name} has {mary.Children.Count} children");
        WriteLine($"{greta.Name} has {greta.Children.Count} children");

        WriteLine($"{harry.Name}'s first child is named {harry.Children[0].Name}");

        harry.Shout += MyDelegates.Harry_Shout;

        harry.Poke();
        harry.Poke();
        harry.Poke();
        harry.Poke();

        // Instantiate the delegate.
        MyDelegate handler = harry.MyMethod;
        // Call the delegate.
        WriteLine(handler("Hello World"));
        //delegate definition
    }

    delegate int MyDelegate(string message);
}

