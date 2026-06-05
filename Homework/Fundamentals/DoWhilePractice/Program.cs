Console.WriteLine("Enter a positive whole number:");

int number;
string? input;

do
{
    Console.Write("Number: ");
    input = Console.ReadLine();

    if (input is null)
    {
        Console.WriteLine("No input was provided.");
        return;
    }
}
while (!int.TryParse(input, out number) || number <= 0);

long current = 1;
long sum = 0;

do
{
    sum += current;
    current++;
}
while (current <= number);

Console.WriteLine($"Sum from 1 to {number}: {sum}");
