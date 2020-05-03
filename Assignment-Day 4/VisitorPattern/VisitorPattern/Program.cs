using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Models;
using VisitorPattern.DocumentConverters;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document _document = new Document("MyDocument");
            _document.Add(new Paragraph());
            _document.Add(new Header());
            _document.Add(new Footer());
            _document.Add(new HyperLink());
            Console.WriteLine("\n");

            //Convert to XPS
            Console.WriteLine("==================");
            Console.WriteLine("Convert to XPS");
            _document.Convert(new XpsConverter());
            Console.WriteLine("==================");
            Console.WriteLine("\n");

            //Convert to HTML
            Console.WriteLine("==================");
            Console.WriteLine("Convert to HTML");
            _document.Convert(new HtmlConverter());
            Console.WriteLine("==================");
            Console.WriteLine("\n");

            //Convert to PDF
            Console.WriteLine("==================");
            Console.WriteLine("Convert to PDF");
            _document.Convert(new PdfConverter());
            Console.WriteLine("==================");

            Console.ReadKey();
        }
    }
}
