using System.Diagnostics;

namespace NullableReference;

public class HiringClass
{
    public void Hire(Person manager, Person employee)
    {
        if (manager is null)
            throw new ArgumentNullException(nameof(manager));
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
    }
}

public class Person
{
    public string Name { get; set; }
}