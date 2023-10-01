using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_5ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(120, -1));
            Console.WriteLine(test(-1, 120));
            Console.WriteLine(test(2 , 120));
            Console.ReadLine();
        }
        public static bool test(int a, int b)
        {
            return a < 0 && b > 100 || b < 0 && a > 100;
        

        }
    }
}
