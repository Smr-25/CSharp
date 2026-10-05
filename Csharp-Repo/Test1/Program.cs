//// See https://aka.ms/new-console-template for more information



int n = 1500;
int m = 2800;

for (int i = n; i < m; i++)
{
    string str = i.ToString();
    for (int j = 0; j < str.Length / 2; j++)
    {
        if (str[j] != str[str.Length - 1 - j])
            break;
        if (j == (str.Length / 2) - 1)
            Console.WriteLine(str);
    }

}

for (int i = n; i < m; i++)
{
    int original = i;
    int reversed = 0;
    int temp = i;
    while (temp > 0)
    {
        int digit = temp % 10;
        reversed = reversed * 10 + digit;
        temp /= 10;
    }
    if (original == reversed)
        Console.WriteLine(original);
}