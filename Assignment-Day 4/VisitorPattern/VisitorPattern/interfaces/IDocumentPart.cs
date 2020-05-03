using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.interfaces;

namespace VisitorPattern
{
    public interface IDocumentPart
    {
        void Convert(IDocumentConverter converter);

        String GetPartType();
    }
}
