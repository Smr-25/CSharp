using System;
using System.Threading;

namespace Pa201LabN6.Models
{
    internal class Courier
    {

        private static int _id;

        public int Id { get; }

        public string Name { get; set; }

        public bool IsAvailable { get; set; }

        //Interlocked.Increment(ref _nextId);
        public Courier(string name, bool isAvailable)
        {
            _id++;
            Id = _id;
            Name = name;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return $"Courier {{ Id = {Id}, Adı = {Name}, IsAvailable = {IsAvailable} }}";
        }
    }
}
