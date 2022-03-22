using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountToN(2);
            CountToN(7);
            CountTo10();
        }
        private static void CountTo10()
        {
            CountToN(10);
            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/
        }
        private static void CountToN(int n)
        {

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i);
            }
        }
    }
}
