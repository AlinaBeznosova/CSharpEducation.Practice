namespace MyLib
{
    public class MathHelper
    {
        private static double result;
        public static void Addition(double x, double y)
        {
            Console.WriteLine($"Результат сложения равен {result = x + y}");
        }

        public static void Substraction(double x, double y)
        {
            Console.WriteLine($"Результат вычитания равен {result = x - y}");
        }

        public static void Multiplication(double x, double y)
        {
            Console.WriteLine($"Результат умножения равен {result = x * y}");
        }

        public static void Division(double x, double y)
        {
            if (y == 0)
            {
               Console.WriteLine($"На ноль делить нельзя");
            }
            else Console.WriteLine($"Результат деления равен {result = x / y}");
        }
    }
}
 
