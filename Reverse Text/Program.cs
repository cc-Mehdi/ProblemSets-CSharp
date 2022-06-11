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
            Console.Write("Enter your first-last name : ");
            //Get first and last name and convert to char list
            char[] chFullName = Console.ReadLine().ToCharArray();
            //Revers char list
            Array.Reverse(chFullName);
            //Write space and print reverse
            for (int i = 0; i < chFullName.Length; i++)
                Console.Write(chFullName[i] + " ");

            Console.ReadKey();
        }
    }
}
