using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 2; i <= 100; i++)
                if (checkPrimeNumber(i)) Console.WriteLine(i);
        }

        private static bool checkPrimeNumber(int i)
        {
            int x, f = 0;
            for (x = 2; x <= i - 1; x++)
            {
                if (i % x == 0) f = 1;
            }
            if (f == 0)
            { return true; }
            else
            { return false; }
        }

    }
}
