namespace BookApp.Interfaces;

public interface IBorrowService
{
    Task CreateBorrowOperationAsync(int bookId, DateTime borrowDate);
    Task ReturnBorrowedBookAsync(int borrowId);
}