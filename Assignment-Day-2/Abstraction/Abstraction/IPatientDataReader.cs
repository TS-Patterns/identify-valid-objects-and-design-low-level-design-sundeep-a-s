using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface IPatientDataReader
    {
        List<PatientModel> GetAllRecords();
        void SetFileName(String fileName);
        bool ValidateFile();
    }
}
