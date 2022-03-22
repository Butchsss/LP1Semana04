using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Main method 
        /// Calls others methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountToN(2);
            CountToN(7);
            CountTo10();
            CountToN(5,8);
        }
        /// <summary>
        /// Method who calls another method to count till 10
        /// </summary>
        private static void CountTo10()
        {
            CountToN(10);
            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/
        }
        /// <summary>
        /// Method that can be used to count till 'n'
        /// When this method is called, it'll count till the number was passed 
        /// in is parameter 
        /// </summary>
        /// <param name="n"></param>
        private static void CountToN(int n)
        {

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Method that can be used to count from n1 till n2
        /// When this method is called, it'll count till the number was passed 
        /// in is parameter, starting with the int given in the first parameter
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private static async void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
