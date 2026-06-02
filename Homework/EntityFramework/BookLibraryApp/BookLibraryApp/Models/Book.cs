namespace BookApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string AuthorName { get; set; }

    public decimal Price { get; set; }
    
    public int StockCount { get; set; }
    
    public List<Borrow> Borrows { get; set; }

    public override string ToString()
    {
        return $"Book Id: {Id}, Name: {Name}, Author: {AuthorName}, Price: {Price}, Count: {StockCount}";
    }
}