using System;

namespace Pa201LabN6.Exceptions
{
    internal class CourierNotAvailableException : Exception
    {
        public CourierNotAvailableException(string message) : base(message)
        {
        }

    }
}
