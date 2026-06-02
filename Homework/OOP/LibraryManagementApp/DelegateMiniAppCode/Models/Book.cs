using DelegateMiniAppCode.Intefaces;

namespace DelegateMiniAppCode.Models;

public class Book : IEntity
{
    public int Id { get; }
    public string Name { get; set; }
    public string AuthorName { get; set; }

    public int PageCount { get; set; }

    public bool IsDeleted { get; set; }

    private static int _id;
    public Book(string name, string authorName, int pageCount)
    {
        _id++;
        Id = _id;
        Name = name;
        AuthorName = authorName;
        PageCount = pageCount;
    }
    public override string ToString()
    {
    return $"Id: {Id}, Name: {Name}, AuthorName: {AuthorName}, PageCount: {PageCount}, IsDeleted: {IsDeleted}";
    }
}


