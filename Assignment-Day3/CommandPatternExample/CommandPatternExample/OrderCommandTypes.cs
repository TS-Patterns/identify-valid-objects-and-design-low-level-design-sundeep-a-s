using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public enum OrderCommandTypes
    {
        CreateCommand = 1,
        ModifyCommand = 2,
        CancelCommand = 3
    }
}
