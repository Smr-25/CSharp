// See https://aka.ms/new-console-template for more information

#region Task1

int[] array = {44,81,13,2,11,6,20,15,10,90};
int sum1 = 0;
int sum2 = 0;
//one way
for(int i = 0; i < array.Length; i++)
    sum1 += array[i];
Console.WriteLine(sum1);
//another way
foreach (int item in array)
    sum2 += item;
Console.WriteLine(sum2);

#endregion

#region Task2

int[] array1 = {27,55,3,18,35,9,21,22,17};
int max = 0;
int max1 = 0;
for (int i = 0; i < array1.Length; i++) {
    if (array1[i] > max)
        max = array1[i];

}
Console.WriteLine(max);

foreach(int item in array1)
{
    if (item > max1)
        max1 = item;
}
Console.WriteLine(max1);

#endregion

#region Task3

int[] array2 = {3,27,55,9,21,35,22};
Console.WriteLine(array2[0] + array2[array2.Length-1]);

#endregion

#region Task4
int n = 1024;

while (n>1)
{
    if (n % 2 == 0)
        n /= 2;
    else
    {
        Console.WriteLine("2nin quvveti deyil");
        return;
    }
}
Console.WriteLine("2nin quvvetidir");

#endregion

#region Task5

int n1 = 1276509;
int count = 0;
while (n1 > 0)
{
    n1 /= 10;
    count++;

}

Console.WriteLine(count);

#endregion

#region Task6

//one way

int[] array3 = {2,6,10,11,13,15,20,44,81,90};
int n2 = 15;
for (int i = 0; i < array3.Length; i++)
{
    if (array3[i] == n2)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine(-1);

//another way
// WARNING! -> When try this way, Please comment line 91 and 93.

int first = 0;
int last = array3.Length - 1;
while (first <= last)
{
    int mid = first + (last - first) / 2;
    if (array3[mid] == n2)
    {
        Console.WriteLine(mid);
        return;
    }
    if (array3[mid] < n2)
        first = mid + 1;
    else
        last = mid - 1;

}
Console.WriteLine(-1);

//WARNING ! When try following tasks, Please comment line 91,93,106,114.

#endregion

#region Task7

int[] numbers = { -5, 3, 78, -90, -12, 25, 75 };
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        numbers[i] += 2;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]+" ");
}

#endregion

#region Task8

int[] numbers1 = { 1, 2, 3, 2, 4, 2 };
int number = 2;
int count1 = 0;
for(int i = 0; i < numbers1.Length; i++)
{
    if (numbers1[i] == number)
          count1++;
}
Console.WriteLine("\n"+count1);

#endregion

#region Task9

int[] array4 = {1, 2, 3, 4};
for(int i = array4.Length - 1; i >= 0; i--)
{
    Console.Write(array4[i]+" ");
}

#endregion

#region Task 10

int[] array5 = { 44, 81, 13, 2, 11, 6, 20, 15, 10, 90 };
int min = array5[0];
for(int i = 1; i < array5.Length; i++)
{
    if (array5[i] < min)
    {
        min = array5[i];
    }
}
Console.WriteLine("\n"+min);

#endregion