using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class PatientLineContentValidator
    {
        public bool ValidateLine(String LineContent)
        {
            if (String.IsNullOrEmpty(LineContent))
                return false;
            else
                return true;
        }
    }
}
