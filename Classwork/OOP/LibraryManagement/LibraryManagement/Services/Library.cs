using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10.Exceptions;
using ConsoleApp10.Models;
namespace ConsoleApp10.Library
{
    internal class Library
    {
        public int BookLimit { get; set; }

        List<Book> Books { get; set; }
        public Library(int bookLimit)
        {
            Books = new();
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {

            if (Books.Count == BookLimit)
                throw new CapacityLimitException("Library is full");

            Books.Add(book);
            Console.WriteLine(Books.Count);
            book.Count++;
            Console.WriteLine("Book Added");
        }

        public Book GetBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("Id is null");

            return Books.FirstOrDefault(b => b.Id == id);
        }

        public void RemoveById(int? id)
        {
            if (GetBookById(id) == null)
                throw new NotFoundException("Book notfound");

            Books.Remove(GetBookById(id));
        }

    }
}
