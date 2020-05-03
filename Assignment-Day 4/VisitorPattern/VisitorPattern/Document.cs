using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.interfaces;

namespace VisitorPattern
{
    public class Document
    {
        private List<IDocumentPart> _documentParts;
        String _documentName;

        public Document(String name)
        {
            _documentParts = new List<IDocumentPart>();
            _documentName = name;
            Console.WriteLine("Created document "+name);
        }

        public void Add(IDocumentPart documentPart)
        {
            _documentParts.Add(documentPart);
            Console.WriteLine("Added part " + documentPart.GetPartType());
        }

        public void Convert(IDocumentConverter converter)
        {
            foreach(IDocumentPart part in _documentParts)
            {
                part.Convert(converter);
            }
        }
    }
}
