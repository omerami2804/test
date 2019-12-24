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
            Console.WriteLine("triangle size?");
            int tri_size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= tri_size; i++)
            {
                for (int j = 0; j < tri_size; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
