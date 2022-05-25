//int x = 0;
//
//while (x < 10)
//{
//    Console.WriteLine(x);
//    x++;
//}

//int x = 10;
//
//do
//{
//    Console.WriteLine(x);
//    x++;
//} while (x < 10);

//string? password = "pippo";

//do
//{
//    Console.Write("Enter password:");
//    password = Console.ReadLine();
//}
//while (password != "pippo");

//while(password != "pippo")
//{
//    Console.Write("Enter password:");
//    password = Console.ReadLine();
//}

//Console.WriteLine("Correct!");

//for (var y = 1; y <= 10; y++)
//{
//    y = 50;
//    Console.WriteLine(y);
//}

using System.Collections;

string[] names = { "Andrea", "Aurora", "Edoardo", "Elena", "Marika"};

foreach (var name in names)
{
    Console.WriteLine($"{name} has {name.Length} characters");
}

IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
    string name = (string)e.Current;
    Console.WriteLine($"{name} has {name.Length} characters");
}