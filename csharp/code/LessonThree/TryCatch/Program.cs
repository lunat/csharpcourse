using static System.Console;

Write("Enter an amount:");
string? amount = ReadLine();
try
{
    decimal amountValue = decimal.Parse(amount);
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amount cannot use $ sign!");
}
catch (FormatException)
{
    WriteLine("Amount must contain digits");
}

//WriteLine("Before parsing");
//Write("What is your age?");
//string? intput = ReadLine();
//try
//{
//    int age = int.Parse(intput);
//    WriteLine($"You are {age} years old.");
//}
//catch (OverflowException ex)
//{
//    WriteLine("The number is too big or too small");
//}
//catch (FormatException ex)
//{
//    WriteLine("The age you entered is not a valid number format!");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()}");
//    WriteLine($"----");
//    WriteLine($"message: {ex.Message}");
//    WriteLine($"----");
//    WriteLine($"InnerException: {ex.InnerException}");
//    WriteLine($"----");
//    WriteLine($"StackTrace: {ex.StackTrace}");
//    WriteLine($"----");
//    WriteLine($"StackTrace: {ex}");
//}
//WriteLine("After parsing");