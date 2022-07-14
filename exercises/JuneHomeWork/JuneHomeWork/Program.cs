using static System.Console;

/*
* 1. dopo ogni stampa il programma deve chiedere all'utente se desidera continuare proponendo Y/N come scelta
*    Y -> ripropone all'utente da domanda di inserire il primo numero, poi il secondo ecc...
*      N -> termina il programma
* 2. correggere gli errori nel programma
* 3. fare refactoring separando i ruoli di ogni classe e metodo, utilizzando classi e interfacce
* 4. scrivere gli Unit Test che verifichino
*      I. che la somma dei due numeri sia corretta (ad esempio 5+6 fa 11)
*      II. quando eseguiamo una stampa, questa venga effettivamente invocata
=================================================================================================
*/

Write("Please insert the first number to add: ");
var firstNumber = ReadLine();
Write("Please insert the second number to add: ");
var secondNumber = ReadLine();
WriteLine("Now where do you want to print the result?");
WriteLine("1 - Xerox LaserJet Multifunction");
WriteLine("2 - HP LaserJet Multifunction");
WriteLine("3 - Epson LaserJet Printer");
WriteLine("4 - Epson DeskJet Printer");
Write("Your choice: ");
var command = ReadLine();



if (command == "1")
{
    var result = firstNumber + secondNumber;
    var xerox = new MultifunctionPrinter();
    xerox.Print(result);
} 
else if (command == "2")
{
    var result = firstNumber + secondNumber;
    var hp = new MultifunctionPrinter();
    hp.Print(result);
} 
else if (command == "3")
{
    var result = firstNumber + secondNumber;
    var epsonLj = new MultifunctionPrinter();
    epsonLj.Print(result);
}
else if (command == "4")
{
    var result = firstNumber + secondNumber;
    var epsonDj = new MultifunctionPrinter();
    epsonDj.Print(result);
}



public class MultifunctionPrinter
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

public class LaserJetPrinter
{
    public int Speed { get; set; }

    public void Print(string textToPrint)
    {
        WriteLine($"LaserJetPrinter is printing {Speed} pages per minute...");
        WriteLine(textToPrint);
    }
}

public class InkJetPrinter
{
    public int Speed { get; set; }

    public void Print(string textToPrint)
    {
        WriteLine($"InkJetPrinter is printing {Speed} pages per minute...");
        WriteLine(textToPrint);
    }
}