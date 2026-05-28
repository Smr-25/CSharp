//See https://aka.ms/new-console-template for more information


int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    sum += number;
}
Console.WriteLine(sum);

int product = 1;
while (true)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
        break;
    product *= number;
}
Console.WriteLine(product);


string password = "admin";
while (true)
{
    string inputPassword = Console.ReadLine();
    if (password == inputPassword)
    {
        Console.WriteLine("Dogru sifre");
        break;
    }
    Console.WriteLine("Tekrar cehd edin");
}

string password2 = "admin";
int attempts = 3;
for (int i = 0; i < attempts; i++)
{
    string inputPassword = Console.ReadLine();
    if (password2 == inputPassword)
    {
        Console.WriteLine("Dogru sifre");
        return;
    }
    else if (i != attempts - 1)
        Console.WriteLine("Tekrar cehd edin");
}
Console.WriteLine("Blok edildi");

Random random = new Random();
int secretNumber = random.Next(20, 30);

while (true)
{
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > secretNumber)
        Console.WriteLine("Daha kicik");
    else if (inputNumber < secretNumber)
        Console.WriteLine("Daha boyuk");
    else
    {
        Console.WriteLine("Tebrikler");
        break;
    }
}

int[] array = { 4, 8, 3, 5, 9 };
int[] array2 = new int[array.Length - 1];
for (int i = 0; i < array2.Length; i++)
{
    array2[i] = (array[i] + array[i + 1]) / 2;
}
foreach (int i in array2)
{
    Console.WriteLine(i);
}

int n3 = Convert.ToInt32(Console.ReadLine());
int[] array3 = new int[n];
array3[1] = 1;
for (int i = 2; i < n; i++)
{
    array3[i] = array3[i - 1] + array3[i - 2];
}
foreach (int i in array3)
{
    Console.Write(i + " ");
}
Console.WriteLine(array3[n - 1]);

int num1 = 0;
int num2 = 1;
int num3 = 0;
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write(num1 + " ");
Console.Write(num2 + " ");
for (int i = 2; i < n1; i++)
{
    num3 = num1 + num2;
    num1 = num2;
    num2 = num3;
    Console.Write(num2 + " ");
}
Console.WriteLine();
Console.WriteLine(num2);

int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
{
    Console.WriteLine("Ne sade ne murekkeb eded");
    return;
}
for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(num1)); i++)
{
    if (number1 % i == 0)
    {
        Console.WriteLine("Murrekkeb eded");
        return;
    }

}
Console.WriteLine("Sade eded");
