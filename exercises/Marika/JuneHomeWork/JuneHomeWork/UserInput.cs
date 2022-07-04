using JuneHomeWork.Helpers;
using JuneHomeWork.Printers;
using static System.Console;
namespace JuneHomeWork;

public static class UserInput
{
    public static decimal NumbersToAdd()
    {
        Write("Please insert the first number to add: ");
        var firstNumber = ReadLine();
        Write("Please insert the second number to add: ");
        var secondNumber = ReadLine();

        if(Numbers.IsNumber(firstNumber, out decimal dfirstNumber) && Numbers.IsNumber(secondNumber, out decimal dsecondNumber))
        {
            return Numbers.Add(dfirstNumber, dsecondNumber);
        }
        return 0;
    }

    public static bool PrintResult(string result)
    {
        WriteLine("Now where do you want to print the result?");
        WriteLine("1 - Xerox LaserJet Multifunction");
        WriteLine("2 - HP LaserJet Multifunction");
        WriteLine("3 - Epson LaserJet Printer");
        WriteLine("4 - Epson DeskJet Printer");
        Write("Your choice: ");
        var commandInput = ReadLine();

        int.TryParse(commandInput, out int command);
        switch (command)
        {
            case 1:
                var xerox = new MultifunctionPrinter();
                xerox.Print(result);
                break;
            case 2:
                var hp = new MultifunctionPrinter();
                hp.Print(result);
                break;
            case 3:
                var epsonLj = new MultifunctionPrinter();
                epsonLj.Print(result);
                break;
            case 4:
                var epsonDj = new MultifunctionPrinter();
                epsonDj.Print(result);
                break;
            default:
                WriteLine($"The command {commandInput} is not available");
                return false;
                
        }

        return true;
    }
}
