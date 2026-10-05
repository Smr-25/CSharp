// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

int num1 = 10;
int num2 = 20;
int sum = 0;
int count = 0;
if (num1 > num2)
    Console.WriteLine("num1>num2 ola bilmez");
else
{
    //    for (int i = num1; i < num2; i++)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            sum += i;
    //            count++;
    //        }

    //    }
   
    while (num1 < num2)
    {
        if (num1 % 2 == 0)
        {
            sum += num1;
            count++;
            
        }
        num1++;

    }
        Console.WriteLine(sum);
        Console.WriteLine(count);
        Console.WriteLine(sum/count);
}
