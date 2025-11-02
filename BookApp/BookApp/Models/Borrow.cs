namespace BookApp.Models;

public class Borrow
{
    public int Id { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime ReturnDate { get; set; }
    
    public int BookId { get; set; }

    public Book Book { get; set; }

    public bool IsReturned { get; set; }

    public override string ToString()
    {
        return $"Borrow Id: {Id}, Book Id: {BookId}, Borrow Date: {BorrowDate}, Return Date: {ReturnDate}, Is Returned: {IsReturned}";
    }
}