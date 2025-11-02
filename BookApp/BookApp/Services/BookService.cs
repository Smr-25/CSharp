using BookApp.Data;
using BookApp.Models;
using Microsoft.EntityFrameworkCore;
using BookApp.Interfaces;

namespace BookApp.Services;

public class BookService : IBookService
{
    private readonly LibraryDbContext _libraryDbContext;
    
    public BookService()
    {
        _libraryDbContext = new LibraryDbContext();
    }

    public async Task CreateBookAsync(string name, string authorName, decimal price, int stockCount)
    {
        await _libraryDbContext.Books.AddAsync(new Book
        {
            Name = name,
            AuthorName = authorName,
            Price = price,
            StockCount = stockCount
        } );
        await _libraryDbContext.SaveChangesAsync();
    }
    
    public async Task UpdateBookAsync(int id,string name, string authorName, decimal price, int count)
    {
        var book = await _libraryDbContext.Books.FindAsync(id);
        if (book == null)
        {
            Console.WriteLine($"Book with Id {id} not found");
            return;
        }
        book.Name = name;
        book.AuthorName = authorName;
        book.Price = price;
        book.StockCount = count;
        
        await _libraryDbContext.SaveChangesAsync();
    }
    
    public async Task DeleteBookAsync(int id)
    {
        var book = await _libraryDbContext.Books.FindAsync(id);
        if (book == null)
        {
            Console.WriteLine($"Book with Id {id} not found");
            return;
        }
        _libraryDbContext.Books.Remove(book);
        await _libraryDbContext.SaveChangesAsync();
    }

    public async Task GetAllBooksAsync()
    {
        var books = await _libraryDbContext.Books.ToListAsync();
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public async Task GetBooksWithBorrowCountAsync()
    {
        var books =  await _libraryDbContext.Books.Include(b=>b.Borrows).OrderByDescending(b=>b.Borrows.Count).Select(b=> new{Name = b.Name,BorrowCount = b.Borrows.Count}).ToListAsync();
        foreach (var book in books)
        { 
            Console.WriteLine($"Book Name: {book.Name}, Borrow Count: {book.BorrowCount}");
        }
    } 
    
    public async Task GetNoStockBooksAsync()
    {
        var books =  await _libraryDbContext.Books.Where(b=>b.StockCount==0).ToListAsync();
        foreach (var book in books)
        { 
            Console.WriteLine(book);
        }
    }

    public async Task GetTopThreeBooksWithHighestPriceAsync()
    {
        var books = await _libraryDbContext.Books.OrderByDescending(b => b.Price).Take(3).ToListAsync();
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public async Task GetBookByMostIncomeAsync()
    {
        var books = await _libraryDbContext.Books.Include(b=>b.Borrows).OrderByDescending(b=>b.StockCount * b.Price).Select(b=> new{Name = b.Name,Income = b.StockCount * b.Price}).ToListAsync();
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
    
    public async Task GetAuthorsByBookCountAsync()
    {
        var authors = await _libraryDbContext.Books.GroupBy(b=>b.AuthorName).Select(b=> new{AuthorName = b.Key, BookCount = b.Count()}).ToListAsync();
        foreach (var author in authors)
        {
            Console.WriteLine(author);
        }
    }
    
}
