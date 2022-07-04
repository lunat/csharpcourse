using static System.Console;
namespace JuneHomeWork.Printers;

public class MultifunctionPrinter : IPrintable, IScannable, ISendable
{
    public int Speed { get; set; }

    public void Print(string textToPrint)
    {
        WriteLine($"MultifunctionPrinter is printing {Speed} pages per minute...");
        WriteLine(textToPrint);
    }
    public void Scan()
    {
        WriteLine("MultifunctionPrinter is scanning...");
    }
    public void Mail()
    {
        WriteLine("MultifunctionPrinter is scanning to mail...");
    }
}

