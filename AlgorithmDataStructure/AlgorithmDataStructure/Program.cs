// See https://aka.ms/new-console-template for more information

#region Task1

int[] array = { 5, 4, 6 };
int[] array2 = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    int factorial = 1;
    for (int j = 1; j <= array[i]; j++)
    {
        factorial *= j;
    }
    array2[i] = factorial;
}
foreach (int num in array2)
    Console.WriteLine(num);


#endregion

#region Task2

int[] numbers = { 44, 12, 35, 88 };
int[] numbers2 = new int[numbers.Length - 1];
int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
        min = numbers[i];
    
}

for(int i = 0; i < numbers.Length-1; i++)
{
    if (numbers[i] == min)
    {
        int temp = numbers[i];
        numbers[i] = numbers[i + 1];
        numbers[i + 1] = temp;
    }
}

for (int i = 0; i < numbers2.Length; i++)
{

    numbers2[i] = numbers[i];

}

foreach (int nums in numbers2)
    Console.WriteLine(nums);


#endregion

#region Task3

string str = "kertenkele";

for (int i = 0; i < str.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < str.Length; j++)
    {
        if (str[i] == str[j])
            count++;
    }
    if (count == 1)
    {
        Console.WriteLine(str[i]);
        break;
    }
}

#endregion

#region Task4

// WARNING! If you want run this task, please uncomment line 76 and 83.
// And comment again for other tasks

int num1 = 2;

if (num1 == 1)
{
    Console.WriteLine("Ne sade ne murekkeb eded");
    //return;
}
for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(num1)); i++)
{
    if (num1 % i == 0)
    {
        Console.WriteLine("Murrekkeb eded");
        //return;
    }

}
Console.WriteLine("Sade eded");

#endregion

#region Task5

int n = 250;
int m = 280;
for (int i = n; i < m; i++)
{
    string str5 = i.ToString();
    string reverseStr = new string(str5.Reverse().ToArray());

    if (str5.Equals(reverseStr))
        Console.WriteLine(str5);
}

#endregion

#region Task6

string str2 = "kertenkele";
int max = 0;
char chr = ' ';
for (int i = 0; i < str2.Length; i++)
{
    int count1 = 1;

    for (int j = i + 1; j < str2.Length; j++)
    {
        if (str2[i] == str2[j])
        {
            count1++;
        }
    }
    if (count1 > max)
    {
        max = count1;
        chr = str2[i];

    }

}
Console.WriteLine(max);
Console.WriteLine(chr);



#endregion