using System;

namespace DoubleMTask
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllTests();

            // //my console lag out when i try to print n > 9999/5
            // int n = 9999;
            // DoubleM doubleM = new DoubleM(n / 5);
            // doubleM.PrintToConsole();

            Console.WriteLine("\r\nDone!!");
        }

        private static void PrintAllTests()
        {
            DoubleM doubleM;
            for (int i = 2; i < 8; i++)
            {
                try
                {
                    Console.WriteLine(i);

                    doubleM = new DoubleM(i);
                    doubleM.PrintToConsole();
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
