using static System.Console;

bool a = true;
bool b = false;

WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}");
WriteLine($"------------------------------------");
WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}");

static bool DoStuff()
{
    WriteLine("I am doing some stuff");
    return true;
}

//bool a = true;
//bool b = false;
//Console.WriteLine($"AND  | a      | b    ");
//Console.WriteLine($"a    | {a & a, -5}      | {a & b,-5}    ");
//Console.WriteLine($"b    | {b & a,-5}      | {b & b,-5}    ");
//Console.WriteLine();
//Console.WriteLine($"OR   | a      | b    ");
//Console.WriteLine($"a    | {a | a,-5}      | {a | b,-5}    ");
//Console.WriteLine($"b    | {b | a,-5}      | {b | b,-5}    ");
//Console.WriteLine();
//Console.WriteLine($"XOR   | a      | b    ");
//Console.WriteLine($"a    | {a ^ a,-5}      | {a ^ b,-5}    ");
//Console.WriteLine($"b    | {b ^ a,-5}      | {b ^ b,-5}    ");


