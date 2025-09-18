//See https://aka.ms/new-console-template for more information

#region Task1

static string SpaceDelete(string str)
{

    string newStr = "";

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
            newStr += str[i];
    }
    str = newStr;

    return str;
}

Console.WriteLine(SpaceDelete(" A B C D E"));

#endregion

#region Task2

static int[] addArray(int[] array, int num)
{
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[array.Length] = num;

    return newArray;
}

foreach (int n in addArray(new int[] { 1, 2, 3 }, 2))
{
    Console.WriteLine(n);
}


#endregion

#region Task3

static string Divide(int n)
{
    if (n % 3 == 0 && n % 7 == 0)
        return "Bolunur";

    return "Bolunmur";
}


Console.WriteLine(Divide(25));


#endregion

#region Task4

static int OddCount(int n, int m)
{
    if (n > m)
        Console.WriteLine("Yanlis daxil edilib");
    int count = 0;
    for (int i = n; i < m; i++)
    {
        if (i % 2 == 1)
            count++;

    }

    return count;
}

Console.WriteLine(OddCount(1, 10));

#endregion

#region Task5

static int OddSum(int n, int m)
{

    if (n > m)
        Console.WriteLine("Yanlis daxil edilib");
    int sum = 0;
    for (int i = n; i < m; i++)
    {
        if (i % 2 == 1)
            sum += i;

    }

    return sum;
}

Console.WriteLine(OddSum(1, 10));

#endregion

#region Task6

static string PrimeOrComposite(int n)
{
    if (n == 1)
        return "Ne sade ne murekkeb";
    for (int i = 2; i < Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return "Murekkeb";

    }
    return "Sade";
}

Console.WriteLine(PrimeOrComposite(18));

#endregion

#region Task7

static int EvenSum(params int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum += array[i];
    }

    return sum;
}

Console.WriteLine(EvenSum(1,2,3,4,5,6,7,8,9));

#endregion

#region Task8

static string SpaceDeleter(string str)
{
    string newStr = "";

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
            newStr += str[i];
    }
    

    return newStr;
}

Console.WriteLine(SpaceDeleter(" s s s s s "));

#endregion

#region Task9

static int LetterCount(string str,char letter)
{
    int count = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if (str[i] == letter)
            count++;
    }
    return count;
}

Console.WriteLine(LetterCount("salam",'a'));

#endregion

#region Task10

static string FirstSpaceDeleter(string str)
{
    string newStr = "";

    for (int i = 0; i < str.Length-1; i++)
    {
        if (str[0] == ' ')
            newStr += str[i + 1];
        else break;
    }
    str = newStr;

    return str;
}

Console.WriteLine(FirstSpaceDeleter(" ssss"));

#endregion

#region Task11

static int Calculate(int num1, int num2, char operation)
{

    switch (operation)
    {
        case '+':
            return num1 + num2;
        case '-':
            return num1 - num2;
        case '*':
            return num1 * num2;
        case '/':
            if (num2 != 0)
                return num1 / num2;
            else
                Console.WriteLine("Sifira bolmek olmaz");
            break;
        default:
            Console.WriteLine("Yanlis simvol, dogru daxil edin");
            break;
    }
    return 0;

}

Console.WriteLine(Calculate(19,5,'*'));

#endregion

#region Task12

static string isHereA(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == 'A')
            return "vardir";
    }
    return "yoxdur";

}

Console.WriteLine(isHereA("Adam"));

#endregion

#region Task13

static int CountA(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == 'A')
            count++;
    }
    return count;

}

Console.WriteLine(CountA("AdamAA"));

#endregion

#region Task14

static int SquareEven(int n)
{
    if (n > 0 && n % 2 == 0)
        return n * n;

    Console.WriteLine("Yeniden daxil edilmelidir");
    return 0;
}

Console.WriteLine(SquareEven(-12));

#endregion

#region Task15

static void EducationHour(string KindOfEducation)
{
    switch (KindOfEducation)
    {
        case "programming":
            Console.WriteLine(400);
            break;
        case "design":
            Console.WriteLine(250);
            break;
        case "system":
            Console.WriteLine(200);
            break;
        default:
            Console.WriteLine("təhsil novu yanlisdir");
            break;
    }
}

EducationHour("programming");

#endregion