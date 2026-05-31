static string DomainReturn(string email)
{
    string domain = "";
    for (int i = 0; i < email.Length; i++)
    {
        if (email[i] == '@')
        {
            domain += email.Substring(i + 1);
            break;
        }
    }

    domain += email.Split('@')[1];

    return domain;
}

Console.WriteLine(DomainReturn("test@code.edu.az"));
