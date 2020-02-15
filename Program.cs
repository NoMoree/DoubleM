using System;

namespace DoubleMTask
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllTests();
        }

        private static void PrintAllTests()
        {
            DoubleM doubleM;
            for (int i = 3; i < 8; i += 2)
            {
                Console.WriteLine(i);

                doubleM = new DoubleM(i);
            }
        }
    }
}
