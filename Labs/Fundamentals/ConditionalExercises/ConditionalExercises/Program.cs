// See https://aka.ms/new-console-template for more information
string name = "Samir";
Console.WriteLine("Salam " + name);
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0) Console.WriteLine("Positive");

else if (num < 0) Console.WriteLine("Negative");

else Console.WriteLine("Zero");


int age = Convert.ToInt32(Console.ReadLine());
if (age > 0 && age < 18) Console.WriteLine("Usaq");

else if (age <= 65) Console.WriteLine("Yetiskin");

else Console.WriteLine("Yasli");


int point = Convert.ToInt32(Console.ReadLine());
if (point > 100 || point < 0)
{
    Console.WriteLine("Wrong Point");
    return;
}
else
{
    if (point >= 90) Console.WriteLine("A");
    else if (point >= 70) Console.WriteLine("B");
    else if (point >= 50) Console.WriteLine("C");
    else Console.WriteLine("F");

}

string firstName = Console.ReadLine();
Console.WriteLine("Salam " + firstName);
















