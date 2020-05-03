using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.interfaces;

namespace VisitorPattern.Models
{
    public class Footer: IDocumentPart
    {
        private String content;
        private const String partType = "Footer";

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
