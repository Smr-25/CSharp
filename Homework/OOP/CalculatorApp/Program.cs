// See https://aka.ms/new-console-template for more information
using ClassesOOPCode;

Calculation calculation = new();


string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
string input3 = Console.ReadLine();

if (!(int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2)))
{
    Console.WriteLine("Input must be number");
    return;
}
Console.WriteLine(calculation.Calculator(num1, num2, input3));