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
            // Smallest Number

            //Get Orginal Number
            Console.Write("Enter Orginal Number : ");
            string OrginalNumber = Console.ReadLine();

            // Convert To Char Array List
            char[] chOrginalNumbers = OrginalNumber.ToCharArray();
            // Sort Array (ASC)
            Array.Sort(chOrginalNumbers);

            //Print Largest
            Console.WriteLine("Largest Digit of the said number : " + chOrginalNumbers[chOrginalNumbers.Length - 1].ToString());
            //Print Smallest
            Console.WriteLine("Smallest Digit of the said number : " + chOrginalNumbers[0].ToString());


            Console.ReadKey();
        }
    }
}
