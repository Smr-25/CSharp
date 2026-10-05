using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Models
{
    internal abstract class Product
    {
        public int Id { get; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        protected decimal TotalInCome { get; set; }

        public abstract void Sell();

        public abstract void ShowInfo();
    }
}
