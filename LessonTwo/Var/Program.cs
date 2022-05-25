using System;
using System.IO;
using System.Xml;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();
            XmlDocument xml3 = new(); //target typed from C#9

            var file1 = File.CreateText("mytext.txt");
            StreamWriter file2 = File.CreateText("mytext.txt");

            DateTime myDateTime;
            myDateTime = new(1976, 12, 2);
        }
    }
}
