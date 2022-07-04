using static System.Console;
namespace JuneHomeWork.Printers;

public class LaserJetPrinter : IPrintable
{
    public int Speed { get; set; }

    public void Print(string textToPrint)
    {
        WriteLine($"LaserJetPrinter is printing {Speed} pages per minute...");
        WriteLine(textToPrint);
    }
}

