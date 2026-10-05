using ConsoleApp10.Library;
using ConsoleApp10.Models;
//Library library = new(3);

//library.AddBook(new Book("Book1", 10, "A1", 100));
//library.AddBook(new Book("Book1", 10, "A1", 100));

//Console.WriteLine(library.GetBookById(1)); 
Library library = new(3);

library.AddBook(new Book("Book1", 10, "A1", 100));
library.AddBook(new Book("Book2", 20, "A1", 200));
library.AddBook(new Book("Book3", 30, "A1", 300));



library.GetBookById(2).ShowInfo();


//Book book = new Book("Book1", 10, "A1", 100);
//book.Count = 5;
//book.Price = 100;
//book.Sell();
//book.Sell();
//book.Sell();
//book.Sell();
//book.Sell();
//book.Sell();
