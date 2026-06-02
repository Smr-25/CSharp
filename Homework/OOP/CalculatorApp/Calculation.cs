namespace ClassesOOPCode
{
    public class Calculation
    {
        public int Calculator(int num1, int num2, string op)
        {
            int result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Divide by Zero isn't acceptable");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            return result;
        }
    }
}
