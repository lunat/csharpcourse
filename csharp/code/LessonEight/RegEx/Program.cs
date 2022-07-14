using System.Text.RegularExpressions;
using static System.Console;

Write("enter your age:");
string? age = ReadLine();
Regex ageChecker = new(@"^\d+$");
if (ageChecker.IsMatch(age))
{
    WriteLine("OK");
}
else
{
    WriteLine($"This is not a valid age {age}");
}