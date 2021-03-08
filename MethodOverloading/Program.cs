using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Interger");
            int num1 = Add(5, 7);
            Console.WriteLine(num1);

            Console.WriteLine("This is Double");
            double num2 = Add(4.3, 6.26);
            Console.WriteLine(num2);

            int sum = Add(2,8);
            bool z = true;
            Console.WriteLine($"if {sum} dollars print: {z}");
        }

        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public static double Add(double num1, double num2)
        {
            return (num1 + num2);
        }

        public static string Add(int x, int y, bool z)
        {
            if (z == true)
            {
                if (x + y != 1)
                {
                    return $"{x + y} dollars";
                }
                else
                {
                    return $"{x + y} dollar";
                }
            }
            else
            {
                return (x + y).ToString();
            }
        }
    }
}
