using static System.Console;
namespace JuneHomeWork.Printers;

public class InkJetPrinter : IPrintable
{
    public int Speed { get; set; }

    public void Print(string textToPrint)
    {
        WriteLine($"InkJetPrinter is printing {Speed} pages per minute...");
        WriteLine(textToPrint);
    }
}
