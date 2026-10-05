using BookApp.Data;
using BookApp.Exceptions;
using BookApp.Interfaces;
using BookApp.Models;

namespace BookApp.Services;



public class BorrowService : IBorrowService
{
    private readonly LibraryDbContext _libraryDbContext;
    
    public BorrowService()
    {
        _libraryDbContext = new LibraryDbContext();
    }
    
    public async Task CreateBorrowOperationAsync(int bookId, DateTime borrowDate)
    {
        var book = await _libraryDbContext.Books.FindAsync(bookId);
        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }
        if (book.StockCount == 0)
        {
            throw new BookOutOfStockException("Book is out of stock");
        }
        book.StockCount -= 1;
       await _libraryDbContext.Borrows.AddAsync(new Borrow
        {
            BookId = bookId,
            BorrowDate = borrowDate,
            IsReturned = false
        });
        await _libraryDbContext.SaveChangesAsync();
    }
    
    public async Task ReturnBorrowedBookAsync(int borrowId)
    {
        var borrow = await _libraryDbContext.Borrows.FindAsync(borrowId);
        if (borrow == null)
        {
            Console.WriteLine($"Borrow record with Id {borrowId} not found");
            return;
        }
        if (borrow.IsReturned)
        {
            throw new AlreadyReturnedException("This book has already been returned");
        }
        borrow.ReturnDate = DateTime.Now;
        borrow.IsReturned = true;

        var book = await _libraryDbContext.Books.FindAsync(borrow.BookId);
        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }
        book.StockCount += 1;
        await _libraryDbContext.SaveChangesAsync();
    }
    
    
    
}