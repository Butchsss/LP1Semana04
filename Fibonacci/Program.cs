using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(8));
        }

        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            int prev = 0;
            int next = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }
    }
}
