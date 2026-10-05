namespace VirtualOverrideAndHiding;

public class Notification
{
    public virtual string GetMessage() => "Base notification";

    public string GetChannel() => "General channel";
}

public class EmailNotification : Notification
{
    public override string GetMessage() => "Email notification";

    public new string GetChannel() => "Email channel";
}

public static class Program
{
    public static void Main()
    {
        EmailNotification email = new();
        Notification notification = email;

        Console.WriteLine($"Derived reference, virtual method: {email.GetMessage()}");
        Console.WriteLine($"Base reference, virtual method: {notification.GetMessage()}");
        Console.WriteLine($"Derived reference, hidden method: {email.GetChannel()}");
        Console.WriteLine($"Base reference, hidden method: {notification.GetChannel()}");
    }
}
