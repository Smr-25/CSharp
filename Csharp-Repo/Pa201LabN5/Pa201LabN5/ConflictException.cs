using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pa201LabN5
{
    internal class ConflictException : Exception
    {
        public ConflictException(string message): base(message) { }
       
    }
}
