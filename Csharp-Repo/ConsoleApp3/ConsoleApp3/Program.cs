// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
int[] array = { 10, 20, 21, 40, 50, 97, 98 };
int n = 50;


//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] == n)
//    {
//        Console.WriteLine(i);
//        break;
//    }
//}
int first = 0;
int last = array.Length - 1;
    while (first <= last)
    {
    int mid = first + (last - first) / 2;
        if (array[mid] == n)
        {
            Console.WriteLine(mid);
            return;
        }

        if (array[mid] < n)
            first = mid + 1;
        else 
            last = mid - 1;
   
    }

Console.WriteLine(-1);
