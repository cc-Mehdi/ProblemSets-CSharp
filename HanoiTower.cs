using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            hanoi(n);
            Console.ReadKey();
        }

        private static void hanoi(int n, string start = "a", string mid = "b", string end = "c")
        {
            if (n == 1)
                Console.WriteLine($"{start} -> {end}");
            else
            {
                hanoi(n - 1, start, end, mid);
                Console.WriteLine($"{start} -> {end}");
                hanoi(n - 1, mid, start, end);
            }
        }
    }
}
