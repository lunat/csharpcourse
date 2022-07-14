using System.ComponentModel;
using static System.Console;


var address = new Address();
address.Building = null;
address.StreetNumber = null;

address.Building = "Building 2";
if (address.Building is not null)
{
    WriteLine("Building is not null");
}

string buildingName = null;

// throws a NullReferenceException
//int x = buildingName.Length;

// null conditional operator
// instead of throwing an exception, assigns null to y
int? y = buildingName?.Length;

// null coalescing operator
int z = buildingName?.Length ?? 0;

WriteLine(z);


class Address
{
    public string? Building; // can be null
    public string Street = string.Empty; // must have a value
    public string City = string.Empty;
    public string Region = string.Empty;
    public int? StreetNumber;
}

