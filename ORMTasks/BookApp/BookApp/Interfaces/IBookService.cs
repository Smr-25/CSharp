namespace BookApp.Interfaces;

public interface IBookService
{
    Task CreateBookAsync(string name, string authorName, decimal price, int stockCount);
    Task UpdateBookAsync(int id,string name, string authorName, decimal price, int count);
    Task DeleteBookAsync(int id);
    Task GetAllBooksAsync();
    Task GetBooksWithBorrowCountAsync();
    Task GetNoStockBooksAsync();
    Task GetTopThreeBooksWithHighestPriceAsync();

    Task GetBookByMostIncomeAsync();

    Task GetAuthorsByBookCountAsync();


}