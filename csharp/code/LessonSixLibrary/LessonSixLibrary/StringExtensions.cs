using System.Text.RegularExpressions;

namespace Shared;

//extension method has to be in a static class
public static class StringExtensions
{
    //extension method has to be static and specify this keyword
    public static bool IsValidEmail(this string input)
    {
        return Regex.IsMatch(input,
            @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}

public class MyClass
{
    public string Name { get; set; }
    public string Surname { get; set; }
}

public class MyClass2
{
    public int Id { get; set; }
    public string FullName { get; set; }
}

public static class Mapper
{
    public static MyClass2 ToMyClass2(this MyClass input)
    {
        return new MyClass2
        {
            FullName = input.Name + " " + input.Surname
        };
    }
}