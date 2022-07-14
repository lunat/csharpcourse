using LessonSix;
using Shared;
using static System.Console;

var email1 = "lunat38@gmail.com";
var email2 = "lunat&gmail.com";

WriteLine($"{email1} is valid: " +
          $"{email1.IsValidEmail()}");

WriteLine($"{email2} is valid: " +
          $"{email2.IsValidEmail()}");

var my = new MyClass
{
    Name = "Luca",
    Surname = "Natali"
};

var my2 = my.ToMyClass2();

WriteLine(my2.FullName);

#region Custom Exceptions
//var john = new Employee
//{
//    Name = "John Doe",
//    DateOfBirth = new(1990, 11, 15),
//    EmployeeCode = "JD001",
//    HireDate = new (2015, 03, 05)
//};
//
//try
//{
//    john.TimeTravel(when: new(1992, 1, 1));
//    john.TimeTravel(when: new(1950, 1, 1));
//}
//catch (PersonException ex)
//{
//    WriteLine(ex.Message);
//}
#endregion Custom Exceptions

#region Casting between superclass and subclass
//var aliceInEmployee = new Employee
//{
//    Name = "Alice", EmployeeCode = "A0001"
//};
//
//Person aliceInPerson = aliceInEmployee;
//
//aliceInEmployee.WriteToConsole();
//aliceInPerson.WriteToConsole();
//
//WriteLine(aliceInEmployee.ToString());
//WriteLine(aliceInPerson.ToString());
//
////Employee aliceAsEmployee = (Employee)aliceInPerson;
//
////declaration pattern avoids to perform explicit cast
//if (aliceInPerson is Employee aliceAsEmployee)
//{
//    WriteLine($"{nameof(aliceInPerson)} is an Employee");
//    //safe explicit cast
//    //Employee aliceAsEmployee = (Employee)aliceInPerson;
//    aliceAsEmployee.WriteToConsole();
//}
//
//// as keyword returns NULL if casting fails
//Employee? aliceAsEmployeeNullable
//    = aliceInPerson as Employee;
//if (aliceAsEmployeeNullable is not null)
//{
//    aliceAsEmployeeNullable.WriteToConsole();
//}

#endregion Casting between superclass and subclass

#region Override example
//var john = new Employee
//{
//    Name = "John Doe",
//    DateOfBirth = new(1990, 11, 15),
//    EmployeeCode = "JD001",
//    HireDate = new (2015, 03, 05)
//};
//
//john.WriteToConsole();
//
//WriteLine(john.ToString());
//
//john.Sing();
//
//var claire = new BestEmployee
//{
//    Name = "Claire Robinson",
//    DateOfBirth = new (1985,12,13)
//};
//claire.Sing();
#endregion Override example


#region Sorting
//Person[] people =
//{
//    new Person() { Name = "Simon" },
//    new Person() { Name = "Jeff" },
//    new Person() { Name = "Marion" },
//    new Person() { Name = "Anna" },
//};
//WriteLine("Initial array:");
//foreach (var p in people)
//{
//    WriteLine($"    {p.Name}");
//}
//
//WriteLine("Sorting people..");
//Array.Sort(people, new PersonComparer());
//foreach (var p in people)
//{
//    WriteLine($"    {p.Name}");
//}
//
////PersonActions.Execute();
#endregion Sorting

#region Hashtable and Dictionary

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
#endregion Hashtable and Dictionary





