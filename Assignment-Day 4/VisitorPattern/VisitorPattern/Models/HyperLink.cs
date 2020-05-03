using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.interfaces;

namespace VisitorPattern.Models
{
    public class HyperLink: IDocumentPart
    {
        private String href;
        private const String partType = "HyperLink";

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
