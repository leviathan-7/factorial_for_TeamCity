using System;

namespace factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("factorial = " + factorial(a));
        }
        public static int factorial(int a)
        {
            int s = 1;
            for (int i = 2; i <= a; i++)
                s *= i;
            return s;
        }
    }
}
