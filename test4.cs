using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.Write("enter number for tree");
            string numasstring = Console.ReadLine();
            num = Convert.ToInt32(numasstring);

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        }
    }
