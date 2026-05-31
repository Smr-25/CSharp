using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10.Exceptions;

namespace ConsoleApp10.Models
{
    internal class Book : Product
    {
        public int Id { get; }
        private int _id;
        public Book(string name,int price,string authorName, int pageCount)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public string AuthorName { get; set; }
        public int PageCount { get; set; }


        public override void ShowInfo()
        {
            Console.WriteLine($"{Id} {Name} {AuthorName} {PageCount}");
        }

        public override void Sell()
        {
            if (Count == 0)
                throw new ProductCountIsZeroException("Product already doesn't exist");
            Count--;
            TotalInCome+=Price;
        }
    }
}
