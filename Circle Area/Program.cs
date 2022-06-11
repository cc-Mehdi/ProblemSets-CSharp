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
            Console.Write("Enter r from circle : ");
            // Get r
            double r = double.Parse(Console.ReadLine());
            //Caculate circle area
            double area = (r * r) * Math.PI;
            Console.WriteLine("Area : " + area);

            Console.ReadKey();
        }
    }
}
