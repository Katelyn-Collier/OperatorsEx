using System;

namespace OperatorsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17 divided by 4 is {quotient} remainder {remainder}");

            }
        }
    }
}
