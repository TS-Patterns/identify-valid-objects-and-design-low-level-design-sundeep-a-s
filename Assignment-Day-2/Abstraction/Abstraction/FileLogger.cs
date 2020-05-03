using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class FileLogger
    {
        private String fileName;
        public FileLogger(String fileName)
        {
            this.fileName = fileName;
        }

        public void Write(String logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
