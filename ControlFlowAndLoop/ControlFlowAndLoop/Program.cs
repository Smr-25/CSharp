// See https://aka.ms/new-console-template for more information

#region Task1
int point = 5;
switch (point)
{
    case 2:
        Console.WriteLine("Pis  ");
        break;
    case 3:
        Console.WriteLine("Kafi");
        break;
    case 4:
        Console.WriteLine("Yaxsi");
        break;
    case 5:
        Console.WriteLine("Ela");
        break;
    default:
        Console.WriteLine("2 - 5 arasi eded daxil edin");
        break;
}

#endregion

#region Task2
int n = 10;
int m = 100;
int sum = 0;
if (n > m)
    Console.WriteLine("n>m ola bilmez");
else
{
    for (int i = n; i < m; i++)
    {
        if (i % 10 == 0)
            sum += i;

    }

    Console.WriteLine(sum);
}

#endregion

#region Task3

int num = 644;
int product = 1;
int digit;
if (Convert.ToString(num).Length != 3)
    Console.WriteLine("Ucreqemli eded daxil et");
else
{
    while (num > 0)
    {
        digit = num % 10;
        product *= digit;
        num /= 10;
    }
    Console.WriteLine(product);
}
#endregion

#region Task4

int num1 = 9909928;
while (num1 > 0)
{
    Console.WriteLine(num1 % 10);
    num1 /= 10;
}

#endregion

#region Task5

int m1 = 30;
int count = 0;
for (int i = 1; i < m1; i++)
{
    if (i % 3 == 0)
        count++;
}
Console.WriteLine(count);

#endregion

#region Task6

int m2 = 30;
int sum1 = 0;
int count1 = 0;

for (int i = 1; i < m2; i++)
{
    if (i % 5 == 0)
    {
        sum1 += i;
        count1++;

    }
}

Console.WriteLine(sum1 / count1);

#endregion

#region Task7

int n1 = 60;
for (int i = 1; i <= n1; i++)
{
    if (n1 % i == 0)
        Console.WriteLine(i);
}

#endregion

#region Task8

int x = 57;
int y = 13;
int max = 0;
for(int i = 0; i < x; i++)
{
    if (i % y == 0)
    {
        max = i;
    }
}
if (max == 0)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(max);
}

#endregion