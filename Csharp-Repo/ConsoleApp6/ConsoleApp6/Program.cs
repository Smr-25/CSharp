
namespace ConsoleApp6
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));
            foreach(var num in SquareArray(11,6))
            {
                Console.Write(num+" ");
            }
            Console.WriteLine(Calculator(19, 5, '+'));
            Console.WriteLine(Calculator(19,5, '-'));
            Console.WriteLine(Calculator(19, 5, '*'));
            Console.WriteLine(Calculator(19, 5, '/'));
            Console.WriteLine(Calculator(19, 0, '/'));
            Console.WriteLine(Calculator(19, 5, '#'));
        }

        public static int Compare(int a,int b,int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > c)
                return b;
           return c;
        }

        public static int Square(int num)
        {
            return num * num;
        }


        public static int[] SquareArray(params int[] array)
        {
            int[] result = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                result[i]= Square(array[i]);
            }
            return result;
        }


        public static int Calculator(int num1, int num2, char operation)
        {
            
            switch (operation)
            {
                case '+':
                    return  num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if(num2 != 0)
                       return num1 / num2;
                    else
                        Console.WriteLine("Sifira bolmek olmaz");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            return 0;
        }
    }
}
