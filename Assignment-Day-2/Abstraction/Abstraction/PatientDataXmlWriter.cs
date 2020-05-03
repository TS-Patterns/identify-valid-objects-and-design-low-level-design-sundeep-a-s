using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class PatientDataXmlWriter
    {
        private String fileName;
        FileLogger logger = new FileLogger("log.txt");
        public PatientDataXmlWriter(String fileName)
        {
            this.fileName = fileName;
        }

        public void WriteToXml(List<PatientModel> patientList)
        {
            try
            {
                foreach (PatientModel patient in patientList)
                {
                    Console.WriteLine("writing patient " + patient.Name + " to xml file " + fileName);
                }
                logger.Write("written to xml");
             }
            catch(Exception ex)
            {
                logger.Write(ex.Message);
            }
        }
    }
}
