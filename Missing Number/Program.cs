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

            //Create a list for save numbers
            int[] numbers = new int[int.Parse(Console.ReadLine())];

            //Get number from user
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write("Enter number " + (i + 1) + " : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Find missing number
            for (int i = 1; i <= numbers.Length; i++)
            {
                bool check = false;
                for (int j = 0; j < numbers.Length; j++)
                    if (i == numbers[j])
                        check = true;
                if (check == false)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
