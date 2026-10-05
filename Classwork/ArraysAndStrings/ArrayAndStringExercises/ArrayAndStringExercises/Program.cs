// See https://aka.ms/new-console-template for more information
int[] numbers = { 12, -1, 5, -11 };

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
        numbers[i] *= -1;

}
foreach (int number in numbers)
    Console.WriteLine(number);

string str = "electronicisland";
char letter = 'c';
int count = 0;
foreach (char c in str)
{
    if (c == letter)
        count++;
}
Console.WriteLine(count);

string str = "Samir";
string str1 = "";
for (int i = str.Length - 1; i >= 0; i--)
    str1 += str[i];

Console.WriteLine(str1);

string str2 = "Samir";
char chr1 = 'a';
bool thereIs = false;
foreach (char c in str2)
{
    if (c == chr1)
    {
        thereIs = true;
        break;
    }
}
Console.WriteLine(thereIs);

string str = "There is no problem";
string str1 = "";
foreach(char c in str)
{
    if (c == ' ')
          continue;
    str1 += c;
}
Console.WriteLine(str1);