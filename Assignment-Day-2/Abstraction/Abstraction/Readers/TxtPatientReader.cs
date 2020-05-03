using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Readers
{
    public class TxtPatientReader : IPatientDataReader
    {
        private String fileName;
        public List<PatientModel> GetAllRecords()
        {
            List<PatientModel> patientList = new List<PatientModel>();
            //Logic to read and serialize text file goes here
            Console.WriteLine("reading text file");
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
            return patientList;
        }

        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }

        public bool ValidateFile()
        {
            Console.WriteLine("validating text file");
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
