using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg 2 darab számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam1 > szam2)
            {
                Console.WriteLine("Az első a nagyobb szám!");
            }
            else
            {
                Console.WriteLine("A második a nagyobb szám!");
            }
            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
