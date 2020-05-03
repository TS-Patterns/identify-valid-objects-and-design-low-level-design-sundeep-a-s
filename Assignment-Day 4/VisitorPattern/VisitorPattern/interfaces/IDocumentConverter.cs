using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Models;

namespace VisitorPattern.interfaces
{
    public interface IDocumentConverter
    {
        void Convert(Paragraph paragraph);

        void Convert(Header header);

        void Convert(Footer footer);

        void Convert(HyperLink hyperLink);
    }
}
