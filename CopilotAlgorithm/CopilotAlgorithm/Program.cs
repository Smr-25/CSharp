// See https://aka.ms/new-console-template for more information

#region Task1

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
int temp1 = 0;
int temp2 = 0;


if (a > b && a > c)
{
    max = a;
    temp1 = max * max;
    temp2 = b * b + c * c ;
}
else if (b > c) {
    max = b;
    temp1 = max * max;
    temp2 = a * a + c * c;
}
else {
    max = c;
    temp1 = max * max;
    temp2 = a * a + b * b;

}
Console.WriteLine(temp1);
Console.WriteLine( temp2);
if (temp1 == temp2)
      Console.WriteLine("Duzbucaqli ucbucaq");
else if (temp1 > temp2)
      Console.WriteLine("Korbucaqli ucbucaq");
else
      Console.WriteLine("Itibucaqli ucbucaq");


#endregion

#region Task2

string str = "market";
if (str.Length % 2 != 0)
    Console.WriteLine(str[(str.Length - 1) / 2]);
else
    Console.WriteLine(str[(str.Length / 2) - 1].ToString() + str[str.Length / 2].ToString()); 

#endregion

#region Task3

int num = 156287945;
int sum = 0;

while (num > 0)
{
    int digit = num % 10;
    if(digit==2 || digit == 3 || digit == 5 || digit == 7)
        sum += digit;
    num /= 10;
}

Console.WriteLine(sum);

#endregion
