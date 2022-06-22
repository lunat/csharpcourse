using LessonSix;
using Shared;
using static System.Console;


Person[] people =
{
    new Person() { Name = "Simon" },
    new Person() { Name = "Jeff" },
    new Person() { Name = "Marion" },
    new Person() { Name = "Anna" },
};
WriteLine("Initial array:");
foreach (var p in people)
{
    WriteLine($"    {p.Name}");
}

WriteLine("Sorting people..");
Array.Sort(people, new PersonComparer());
foreach (var p in people)
{
    WriteLine($"    {p.Name}");
}

//PersonActions.Execute();



//System.Collections.Hashtable lookupObject = new();
//lookupObject.Add(1, "Alpha");
//lookupObject.Add(2, "Beta");
//lookupObject.Add(3, "Gamma");
//lookupObject.Add("4", "Delta");
//WriteLine($"Key 2 has value {lookupObject[2]}");
//WriteLine($"Key 4 has value {lookupObject["4"]}");
//
//Dictionary<int, string> lookupIntString = new();
//lookupIntString.Add(1, "Alpha");
//lookupIntString.Add(2, "Beta");
//lookupIntString.Add(3, "Gamma");
//lookupIntString.Add(4, "Delta");
//WriteLine($"Key 2 has value {lookupIntString[2]}");
//WriteLine($"Key 4 has value {lookupIntString[4]}");





