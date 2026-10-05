// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ");
int n = 6;
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(new string(' ', n - i) + new string('#', i));


}

int[] number = {1,2,3,4,5, 6, 7, 8, 9 };
int num = 10;
int[] number2 = new int[number.Length + 1];
for (int i = 0; i < number.Length; i++)
{
    number2[i] = number[i];
}
number2[number.Length] = num;
foreach(int i in number2)
    Console.WriteLine(i);
