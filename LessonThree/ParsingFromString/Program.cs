using static System.Console;

//int age = int.Parse("27");
//DateTime birthDay = DateTime.Parse("4 July 1980");
//WriteLine($"I was born {age} years ago");
//WriteLine($"My birthday is {birthDay}");
//WriteLine($"My birthday is {birthDay:D}");

Write("How many eggs are there?");
string? input = ReadLine();

if (int.TryParse(input, out int value))
{
    WriteLine($"There are {value} eggs.");
}
else
{
    WriteLine("Could not parse input");
}