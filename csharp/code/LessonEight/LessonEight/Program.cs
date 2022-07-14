using System.Text;
using static System.Console;

string city = "London";

WriteLine($"{city} is {city.Length} characters long");
WriteLine($"First char is {city[0]} and third is {city[2]}");

string cities = "Paris,Rome,Sydney,New York,Berlin,Madrid";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array");

foreach (var item in citiesArray)
{
    WriteLine(item);
}

string fullName = "Michael Jordan";
int indexOfTheSpace = fullName.IndexOf(' ');
string firstName = fullName.Substring(0
    , indexOfTheSpace);
string lastName = fullName.Substring(indexOfTheSpace + 1);
WriteLine($"{firstName} {lastName}");

string company = "Microsoft";
bool startsWithM = company.StartsWith("M");
bool endsWithM = company.EndsWith("M");
bool containsN = company.Contains("N");

var emptyString = string.Empty; // ""

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

string fruit = "Apples";
decimal price = 0.39M;
DateTime when = DateTime.Today;
WriteLine($"interpolated: {fruit} cost {price:C} on when {when:dddd}");
WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}",
    arg0: fruit,
    arg1: price,
    arg2: when));

string mystring = "first";
mystring += ", second";
mystring += ", third";
WriteLine(mystring);

StringBuilder myStringBuilder = new StringBuilder("first");
myStringBuilder.Append(", second");
myStringBuilder.Append(", third");
WriteLine(myStringBuilder);