using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneHomeWork.Printers;

public class Printer
{
    private ICollection<IPrintable> _printers;

    public Printer(ICollection<IPrintable> printers)
    {
        _printers = printers;
    }
    public void Print(string textToPrint)
    {
        foreach (var p in _printers)
        {
            p.Print(textToPrint);
        }
    }
}
