using Abstraction.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class PatientDataConverter
    {
        public List<PatientModel> ReadPatientData(DataReaderType type, String fileName)
        {
            List<PatientModel> patientList = new List<PatientModel>();
            IPatientDataReader dataReader = null;
            switch(type)
            {
                case DataReaderType.CsvReader: dataReader = new CsvPatientReader();
                    break;
                case DataReaderType.TxtReader: dataReader = new TxtPatientReader();
                    break;
                default: break;
            }
            if(dataReader!=null)
            {
                dataReader.SetFileName(fileName);
                if(dataReader.ValidateFile())
                {
                    patientList = dataReader.GetAllRecords();
                }
            }
            return patientList;
        }

        public void WriteToXml(List<PatientModel> patientData)
        {
            PatientDataXmlWriter xmlWriter = new PatientDataXmlWriter("abc.xml");
            xmlWriter.WriteToXml(patientData);
        }
    }
}
