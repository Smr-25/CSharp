// See https://aka.ms/new-console-template for more information


int[] array = { -1, 5, 6, -4, 3, -2, -8 };

static int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            array[i] *= -1;
    }

    return array;
}

foreach (int i in ChangeArray(array))
    Console.WriteLine(i);


static string Repeat(string word, int count)
{
    string str = string.Empty;
    for (int i = 0; i < count; i++)
        str += word;
    return str;
}

Console.WriteLine(Repeat("Ha!", 3));


static bool IsPolidromString(string str)
{
    string reverseStr = Reverse(str);
    if (str.Equals(reverseStr))
        return true;
    return false;
}

Console.WriteLine(IsPolidromString("pop"));


static string RemoveDublicates(string str)
{
    string str2 = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str2.Contains(str[i]))
            continue;
        str2 += str[i];
    }

    return str2;
}

Console.WriteLine(RemoveDublicates("aaabbbccc"));


static string Reverse(string str)
{
    string reversedStr = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        reversedStr += str[i];
    }

    return reversedStr;
}

Console.WriteLine(Reverse("pa201"));


static void PrintStrings(string str)
{
    string[] array = str.Split(" ");

    foreach (string s in array)
        Console.WriteLine(s);
}

PrintStrings("Salam Code Academy");


static void PrintString(string str)
{
    if (str.Length < 4)
    {
        Console.WriteLine("Invalid string");
        return;
    }

    for (int i = 0; i < 4; i++)
        Console.Write(str[i]);
}

PrintString("salam");
Console.WriteLine();


string email = "test.user@code.edu.az";

static string FixEmail(ref string email)
{
    string domain = email.Substring(email.IndexOf("@") + 1);
    email = email.Substring(0, email.IndexOf("@"));

    return domain;
}


string domain = FixEmail(ref email);
Console.WriteLine(email);
Console.WriteLine(domain);


string str1 = "rmzysf";

static bool ContainOnlyLetters(string str1)
{
    for (int i = 0; i < str1.Length; i++)
    {
        if (!char.IsLetter(str1[i]))
            return false;
    }

    return true;
}

Console.WriteLine(ContainOnlyLetters(str1));


string str = "saLAm nEceSen";

static string ChangeString(string str)
{
    str = str.ToLower();
    string newStr = str[0].ToString().ToUpper() + str.Substring(1);

    return newStr;
}

Console.WriteLine(ChangeString(str));


string[] fullnames = { "Samir Almammadli", "Ramiz Yusifov", "Tofiq Tofiqli" };

static string[] Names(string[] fullnames)
{
    string[] names = new string[fullnames.Length];

    for (int i = 0; i < fullnames.Length; i++)
    {
        string[] parts = fullnames[i].Split(' ');
        names[i] = parts[0];
    }

    return names;
}

foreach (string s in Names(fullnames))
    Console.WriteLine(s);