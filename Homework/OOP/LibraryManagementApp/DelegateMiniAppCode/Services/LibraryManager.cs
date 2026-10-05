using Utils.Exceptions;
using DelegateMiniAppCode.Models;


namespace DelegateMiniAppCode;

public class LibraryManager
{
    public int Limit { get; set; } = 2;

    private List<Book> Books { get; set; }

    public LibraryManager()
    {
        Books = new();
    }
    public void AddBook(Book book)
    {

        if (Books.Count == Limit)
            throw new CapacityLimitException("Capacity is full");

        if (Books.Any(b => b.Name.ToLower() == book.Name.ToLower() && !b.IsDeleted))
            throw new AlreadyExistsException($"{book.Name} is already exist");
        Books.Add(book);
        Console.WriteLine($"{book.Id} Book is added");
    }

    public Book GetBookById(int? id)
    {
        if (id is null)
            throw new NullReferenceException($"{id} cannot be null");

        var existBook = Books.FirstOrDefault(b => b.Id == id && !b.IsDeleted);
        if (existBook is null)
            throw new NotFoundException($"{id} book notfound");
        return existBook;
    }

    public List<Book> GetAllBooks()
    {
        return Books.FindAll(b => !b.IsDeleted);
    }

    public void DeleteBookById(int? id)
    {
        var existBook = GetBookById(id);
        existBook.IsDeleted = true;
        Console.WriteLine($"{existBook.Id} book is deleted");
    }

    public void EditBook(int? id, string newName)
    {
        var existBook = GetBookById(id);
        if (Books.Any(b => b.Name.ToLower() == newName.ToLower() && b.Id != id && !b.IsDeleted))
            throw new AlreadyExistsException($"{newName} is already exist");
        existBook.Name = newName;
        Console.WriteLine($"{existBook.Id} book name is edited");
    }
    
    public List<Book> FilterByPageCount(int min, int max)
    {
        return Books.FindAll(b => b.PageCount >= min && b.PageCount <= max && !b.IsDeleted);
    }
}
