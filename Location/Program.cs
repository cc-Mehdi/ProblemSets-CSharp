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
            // Create a temp page in size : 4x4 cell
            int[,] pos = new int[4, 4];
            int x = 0, y = 0, s = 0;

            //Get points location
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter X" + (i + 1) + " : ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y" + (i + 1) + " : ");
                y = int.Parse(Console.ReadLine());
                pos[x, y] = 1;
            }

            //vertical check
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    if (pos[i, j] == 1)
                        s++;
                if (s == 3)
                {
                    Console.WriteLine("Dots is set in vertical line");
                    s = 0;
                    break;
                }
                s = 0;
            }
            //horizonatl check
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    if (pos[j, i] == 1)
                        s++;
                if (s == 3)
                {
                    Console.WriteLine("Dots is set in horizontal line");
                    break;
                }
                s = 0;
            }

            Console.ReadKey();
        }
    }
}
