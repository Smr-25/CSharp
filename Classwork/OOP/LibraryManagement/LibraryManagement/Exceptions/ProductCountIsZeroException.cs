using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Exceptions
{
    internal class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException(string message) : base(message) { }
        
    }
}
