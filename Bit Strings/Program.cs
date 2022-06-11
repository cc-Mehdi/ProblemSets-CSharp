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
            // Bit Strings 

            Console.Write("Enter Bit Counts : ");
            int bitCount = int.Parse(Console.ReadLine());

            string result = Math.Pow(2, bitCount).ToString();
            Console.WriteLine("Output : " + result);


            Console.ReadKey();
        }
    }
}
