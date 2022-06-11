using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(n + " ");
            while (n > 1)
            {
                if (n % 2 == 0)
                    Console.Write((n = n / 2) + " ");
                else
                    Console.Write((n = n * 3 + 1) + " ");
            }

            Console.ReadKey();
        }
    }
}
