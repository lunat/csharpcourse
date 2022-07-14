using static System.Console;
namespace Shared;

public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateTime HireDate { get; set; }

    public new void WriteToConsole()
    {
        WriteLine(format:
            "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            arg0: Name,
            arg1: DateOfBirth,
            arg2: HireDate
            );
    }

    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }

    public sealed override void Sing()
    {
        WriteLine($"{Name} is singing very well");
    }
}