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
            Console.Write("Enter your text : ");

            //Get DNA string
            string text = Console.ReadLine();

            //Convert DNA string to char
            char[] chText = text.ToCharArray(), chChars = { 'A', 'T', 'C', 'G' };
            int s = 0, res = 0;

            //Find the longest repetition 
            for (int i = 0; i < chChars.Length; i++)
            {
                for (int j = 0; j < chText.Length; j++)
                    if (chChars[i] == chText[j])
                        s++;
                if (s > res)
                    res = s;
                s = 0;
            }
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
