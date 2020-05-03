using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Readers
{
    public class CsvPatientReader : IPatientDataReader
    {
        private String fileName;
        FileLogger logger = new FileLogger("log.txt");
        public List<PatientModel> GetAllRecords()
        {
            List<PatientModel> patientList = new List<PatientModel>();
            try
            {
                //Logic to read and serialize csv file goes here

                Console.WriteLine("reading csv file");
                for (int i = 0; i < 10; i++)
                {
                    PatientModel patient = new PatientModel();
                    patient.Name = "Patient" + i;
                    patient.Mrn = i.ToString();
                    patient.PhoneNumber = "9897799787";
                    patient.Email = "abc@xyz.com";
                    patient.City = "city";
                    patient.Country = "country";
                    patientList.Add(patient);
                }
                logger.Write("reading patient list complete");
            }
            catch(Exception ex)
            {
                logger.Write(ex.Message);
            }
            return patientList;

        }

        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public bool ValidateFile()
        {
            Console.WriteLine("validating csv file");
            //Logic to validate csv file
            //for(line from file)
            //{
            String lineContent = "lineContent";// read line content from file iteratively
                PatientLineContentValidator validator = new PatientLineContentValidator();
                if (!validator.ValidateLine(lineContent))
                    return false;
            //}
            return true;
        }
    }
}
