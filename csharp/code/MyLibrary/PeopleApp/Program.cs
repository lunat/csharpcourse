using ModernCSharpLibrary;
using static System.Console;
using MyLibrary;


ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Bezos"
};

ImmutableVehicle car = new()
{
    Brand = "Renault",
    Color = "Black",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car with { Color = "Red" };

WriteLine($"Original Car was {car.Color}");
WriteLine($"New Car is {repaintedCar.Color}");

/*
object[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_425 },
    new FirstClassPassenger { AirMiles = 16_571 },
    new BusinessClassPassenger(),
    new CoachClassPassenger { CarryOnKg = 25.7 },
    new CoachClassPassenger { CarryOnKg = 0 }
};

foreach (var passenger in passengers)
{
    var flightCost = passenger switch
    {
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500m,
            > 1200 => 1750m,
            _ => 2000m
        },
        BusinessClassPassenger => 1000m,
        CoachClassPassenger p => p.CarryOnKg switch
        {
            < 10.0 => 500m,
            _  => 800m
        },
        _ => throw new ArgumentException()
    };
    WriteLine($"Flight Cost {flightCost} Euro for {passenger}");
}


foreach (var passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000  => 1500m,
        FirstClassPassenger p when p.AirMiles > 1200   => 1750m,
        FirstClassPassenger _                          => 2000m,
        BusinessClassPassenger _                       => 1000m,
        CoachClassPassenger p when p.CarryOnKg < 10.0  => 500m,
        CoachClassPassenger _                          => 800m
    };
    WriteLine($"Flight Cost {flightCost} Euro for {passenger}");
}
*/


/*
#region Person
var sam = new Person
{
    Name = "Sam",
    DateofBirth = new(1985, 5, 3)
};

WriteLine(sam.Origin);
WriteLine(sam.Greetings);
WriteLine(sam.Age);
sam.FavoriteIceCream = "Chocolate-Cream";
sam.FavoritePrimaryColor = "red";
WriteLine($"{sam.Name} fav icecream is {sam.FavoriteIceCream} " +
          $"and favcolor is {sam.FavoritePrimaryColor}");

sam.Children.Add(new Person { Name = "Carla" });
sam.Children.Add(new Person { Name = "Rose" });
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

var l = new LifeTheUniverseAndEverything();
var myData = l.GetTheData();
WriteLine($"{myData.Text} {myData.Number}");

var myTuple = l.GetTheDataAsTuple();
WriteLine($"{myTuple.Message} {myTuple.Code}");

var (myMessage, myNumber) = l.GetTheDataAsTuple();
WriteLine($"Deconstructed: {myMessage} {myNumber}");


var blankPerson = new Person();

var bob = new Person(homePlanet: "Earth", initialName: "Bob Smith")
{
    DateofBirth = new DateTime(1940, 11, 5),
    FavoritesWonders = (Wonders)66
};

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Karen" });


WriteLine(bob.OptionalParameters("Run!", 0.0));
WriteLine(bob.OptionalParameters("Run!", 0.0, false));

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before a = {a}, b = {b} c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After a = {a}, b = {b} c = {c}");

#endregion Person

#region Deconstructor
var (name1, dob1) = bob;
var (name2, dob2, fav2) = bob;

WriteLine($"Deconstructed values: {name1} {dob1}");
WriteLine($"Deconstructed values: {name2} {dob2} {fav2}");
#endregion Deconstructor


#region First Tests
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int i = 0; i < bob.Children.Count; i++)
{
    WriteLine($"    {bob.Children[i].Name}");
}

WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} is from {bob.HomePlanet}");
WriteLine();
WriteLine($"{blankPerson.Name} was created at {blankPerson.Instantiated}");
WriteLine($"{bob.Name} was created at {bob.Instantiated}");
WriteLine();
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
#endregion First Tests
*/

//WriteLine("{0} was born on {1:dddd, d MMMM yyyy}. Wonders are {2}",
//    bob.Name,
//    bob.DateofBirth,
//    bob.FavoritesWonders);

// --- BANK ACCOUNT ---
//BankAccount.InterestRate = 0.012m;
//BankAccount bobAccount = new();
//bobAccount.AccountName = "Mr. Smith";
//bobAccount.Balance = 4000;

//WriteLine($"{bobAccount.AccountName} earned " +
//          $"{bobAccount.Balance * BankAccount.InterestRate}");

//BankAccount sallyAccount = new();
//sallyAccount.AccountName = "Mrs. Jones";
//sallyAccount.Balance = 30000;

//WriteLine($"{sallyAccount.AccountName} earned " +
//          $"{sallyAccount.Balance * BankAccount.InterestRate}");