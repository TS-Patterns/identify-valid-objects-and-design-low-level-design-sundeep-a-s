﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.interfaces;
using VisitorPattern.Models;

namespace VisitorPattern.DocumentConverters
{
    public class PdfConverter:IDocumentConverter
    {
        public void Convert(Paragraph paragraph)
        {
            Console.WriteLine("Convert paragraph to PDF");
        }

        public void Convert(Header header)
        {
            Console.WriteLine("Convert header to PDF");
        }

        public void Convert(Footer footer)
        {
            Console.WriteLine("Convert footer to PDF");
        }

        public void Convert(HyperLink hyperLink)
        {
            Console.WriteLine("Convert html to PDF");
        }
    }
}
