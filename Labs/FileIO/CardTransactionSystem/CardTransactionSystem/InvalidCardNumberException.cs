using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pa201LabN5
{
    internal class InvalidCardNumberException : Exception
    {
        public InvalidCardNumberException(string message) : base(message) { }
    
    }
}
