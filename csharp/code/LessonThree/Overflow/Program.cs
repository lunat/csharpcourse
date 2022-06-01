using static System.Console;

Write("enter first number:");
string? first = ReadLine();
Write("enter second number:");
string? second = ReadLine();

int.TryParse(first, out int f);
int.TryParse(second, out int s);
try
{
    var result = f / s;
    WriteLine(result);
}
catch (DivideByZeroException e)
{
    WriteLine(e);
    throw;
}

//try
//{
//    unchecked
//    {
//        int x = int.MaxValue - 1;
//        WriteLine(x);
//        x++;
//        WriteLine(x);
//        x++;
//        WriteLine(x);
//        x++;
//        WriteLine(x);
//    }
//}
//catch (OverflowException)
//{
//    WriteLine("The code overflowed but I caught the exception");
//}