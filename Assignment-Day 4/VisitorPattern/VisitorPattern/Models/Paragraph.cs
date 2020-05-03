using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.interfaces;

namespace VisitorPattern.Models
{
    public class Paragraph: IDocumentPart
    {
        private String Content;
        private int LineCount;
        private const String partType = "Paragraph";

        public void Convert(IDocumentConverter converter)
        {
            converter.Convert(this);
        }

        public string GetPartType()
        {
            return partType;
        }
    }
}
