using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSet_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your char : ");

            //The first method
            Console.WriteLine(Console.ReadLine().ToUpper());

            //The second method
            //char ch = char.Parse(Console.ReadLine());
            //int ch_ASCI = Convert.ToInt32(ch);
            //ch = Convert.ToChar(ch_ASCI - 32);
            //Console.WriteLine(ch);

            Console.ReadKey();
        }
    }
}
