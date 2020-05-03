using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientDataConverter dataConverter = new PatientDataConverter();

            //logic for csv reader
            List<PatientModel> patientData = dataConverter.ReadPatientData(DataReaderType.CsvReader, "abc.csv");
            dataConverter.WriteToXml(patientData);

            //logic for txt reader
            patientData = dataConverter.ReadPatientData(DataReaderType.TxtReader, "abc.txt");
            dataConverter.WriteToXml(patientData);

            Console.ReadLine();
        }
    }
}
