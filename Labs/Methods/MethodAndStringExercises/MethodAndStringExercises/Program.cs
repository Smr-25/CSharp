using System;

static int Calculate(char op, params int[] array)
{
    int result = 0;
    switch (op)
    {
        case '+':
            foreach (int i in array)
            {
                result += i;
            }
            break;
        case '*':
            result = 1;
            foreach (int i in array)
            {
                result *= i;
            }
            break;
        default:
            Console.WriteLine("Operator yanlisdir.");
            return 0;
    }
    return result;
}

Console.WriteLine(Calculate('*', 1, 2, 3, 4, 5));

static void Logging(DateTime dateTime, string logMessage, string logType = "Info")
{
    Console.WriteLine($"{dateTime.ToString("yyyy/M/dd")} - {logType} : {logMessage}");

}

Logging(DateTime.Now, "Istifadeci tapilmadi.");


int balance = 1000;
int amount = 500;



static void ProcessPayment(ref int balance, int amount)

{
    if (balance >= amount)
        balance -= amount;
    else
        Console.WriteLine("Balans kifayet deyil");

}
ProcessPayment(ref balance, amount);
Console.WriteLine(balance);




string email = "test.user@code.edu.az";
static void EmailCheck(string email)
{

    if (string.IsNullOrEmpty(email))
    {
        Console.WriteLine("Email bos ola bilmez");
        return;
    }
    if (!email.Contains('@'))
    {
        Console.WriteLine("@ isaresi yoxdur");
        return;
    }
    //int atIndex = email.IndexOf("@");
    //int dotIndex = email.LastIndexOf('.');

    if (!email.Substring(email.IndexOf('@')+1).Contains('.')) //dotIndex < atIndex
    {
        Console.WriteLine("@ isaresinden sonra noqte olmalidir");
        return;
    }
    Console.WriteLine("Ugurludur");


}

EmailCheck(email);

static string FixEmail(ref string email)
{
    string domain = email.Substring(email.IndexOf("@") + 1);
    email = email.Substring(0, email.IndexOf("@"));
   
    return domain;

}


string domain = FixEmail(ref email);
Console.WriteLine(email);
Console.WriteLine(domain);



static string[] RemoveName(string[] names,params string[] removeNames)
{
    string[] removedNames = new string[names.Length-removeNames.Length];
    for (int i = 0; i < names.Length; i++)
    {
        for (int j = 0; j < removeNames.Length; j++)
        {
            if (names[i] == removeNames[j])
            {
                names[i] = null;
                break;
            }
        }
    }
    int u = 0;
    for (int j = 0; j < names.Length; j++)
    {
        if (names[j] != null)
        {
            removedNames[u] = names[j];
            u++;
        }


    }
    return removedNames;
}

string[] str = { "test", "user", "code", "edu", "az" };
string[] str2 = RemoveName(str, "code", "edu");
Console.WriteLine(string.Join(", ",str2));


static void RepairNames(string wreckedNames)
{
    string[] fixedStrArray = wreckedNames.Split(';');
    for(int i = 0;i < fixedStrArray.Length; i++) 
    {
        fixedStrArray[i] = fixedStrArray[i].Replace("?", "a");
        //fixedStrArray[i] = wreckedNames[i][0].ToString();
        //(int)char -->> Ascii code

    }

}

//notes.io