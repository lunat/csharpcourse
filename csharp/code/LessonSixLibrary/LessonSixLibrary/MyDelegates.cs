using static System.Console;
namespace Shared;

public static class MyDelegates
{
    public static void Harry_Shout(object? sender, EventArgs e)
    {
        if (sender == null) return;
        Person p = (Person)sender;
        WriteLine($"{p.Name} is angry at level {p.AngerLevel}");
    }
}