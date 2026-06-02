using System.Data;
using Utils.Enums;
using DelegateMiniAppCode.Models;
using DelegateMiniAppCode.Services;

Console.WriteLine("Enter Name");
string name = Console.ReadLine();
Console.WriteLine("Enter Email");
string email = Console.ReadLine();
Console.WriteLine("Enter Role 1-Admin 2-Member");
Role: int roleInt = Convert.ToInt32(Console.ReadLine());
if (roleInt!=1 && roleInt!=2)
{
    Console.WriteLine("There is no role like this");
    goto Role;
}
Rule role = (Roles)roleInt;
User user = new(name, email, role);
Console.WriteLine("-------------------------");
Console.WriteLine(user);
LibraryManager libraryManager = new();
Console.WriteLine();
Book book = new("Book1", "Author1", 100);
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Menu ");
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Get book by id");
    Console.WriteLine("3. Get all books");
    Console.WriteLine("4. Delete book by id");
    Console.WriteLine("5. Edit book name");
    Console.WriteLine("6. Filter by page count");
    Console.WriteLine("0. Quit");
    Console.WriteLine();
    Console.WriteLine("Choose Option");
Option: string optionStr = Console.ReadLine();
    bool isCorrectFormatOption = int.TryParse(optionStr, out int option);

    if (isCorrectFormatOption)
    {
        switch (option)
        {
            case 1:
                libraryManager.AddBook(book);
                break;
            case 2:
                Console.WriteLine(libraryManager.GetBookById(1));
                break;
            case 3:
                foreach (var b in libraryManager.GetAllBooks())
                    Console.WriteLine(b);
                break;
            case 4:
                libraryManager.DeleteBookById(1);
                break;
            case 5:
                libraryManager.EditBook(1,"BookEdited1");
                break;
            case 6:
                foreach (var b in libraryManager.FilterByPageCount(20, 120))
                    Console.WriteLine(b);
                break;
            case 0:
                return;
            default:
                Console.WriteLine("There is no option like this");
                break;

        }
    }

}


    

