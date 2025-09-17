// See https://aka.ms/new-console-template for more information

#region Task1

int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];
int[] newArray = new int[3];
int i = 0;
while (number > 0)
{
    int digit = number % 10;
    array[i] = digit;
    i++;
    number /= 10;
}

if (array[0] > array[1] && array[0] > array[2])
{
    newArray[0] = array[0];
    if (array[1] > array[2])
    {
        newArray[1] = array[1];
        newArray[2] = array[2];
    }
    else
    {
        newArray[1] = array[2];
        newArray[2] = array[1];
    }
}
else if (array[1] > array[2])
{
    newArray[0] = array[1];
    if (array[0] > array[2])
    {
        newArray[1] = array[0];
        newArray[2] = array[2];
    }
    else
    {
        newArray[1] = array[2];
        newArray[2] = array[0];
    }
}
else
{
    newArray[0] = array[2];
    newArray[1] = array[1];
    newArray[2] = array[0];
}

foreach(int num in newArray)
    Console.Write(num);



#endregion


#region Task2

//WARNING: If you want this task, uncomment line 81 and again comment line 81

int number1 = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[number1.ToString().Length];
int z = 0;
while (number1 > 0)
{

   int digit1 = number1 % 10;
   array1[z] = digit1;
   z++;
   number1 /= 10;
}

for (int j = 0; j < array1.Length - 1; j++)
{
   if (array1[j] <= array1[j + 1])
   {
       Console.WriteLine("artan deyil");
       //return;
   }
}

Console.WriteLine("artandir");

#endregion


#region Task3

int number2 = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int[number2.ToString().Length];
int t = 0;
while (number2 > 0)
{

   int digit2 = number2 % 10;
   array2[t] = digit2;
   t++;
   number2 /= 10;
}

for (int j = 1; j < array2.Length; j++)
{
   if (array2[0] != array2[j])
   {
       Console.WriteLine("Fərqli rəqəmlər var");
       return;
   }
}

Console.WriteLine("Bütün rəqəmlər eynidir");
#endregion