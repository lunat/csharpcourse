using static System.Console;
namespace JuneHomeWork.Helpers;

public static class Numbers
{
    public static decimal Add(decimal number1, decimal number2)
    {
        return number1 + number2;
    }

    public static bool IsNumber(string numberInput, out decimal numberParsed)
    {
        numberParsed = 0;
        try
        {
            numberParsed = decimal.Parse(numberInput);
            return true;
        }
        catch (OverflowException)
        {
            WriteLine("The number is too big or too small");
        }
        catch (FormatException ex)
        {
            WriteLine("The number you entered is not a valid number format!");
        }
        catch (Exception ex)
        {
            WriteLine($"innerExcpetion: {ex.InnerException}");
        }

        return false;
    }
}
