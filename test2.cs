using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" enter n. of seconds: ");
            string secondstotalAsString = Console.ReadLine();
            int secondstotal;
            secondstotal = Convert.ToInt32(secondstotalAsString);

            if (secondstotal >= 0)
            {
                int milliseconds = secondstotal / 1000;
                int minutes = secondstotal * 60;
                int hours = minutes * 60;
                int days = hours * 24;

                Console.WriteLine("a." + days);
                Console.WriteLine("b." + hours);
                Console.WriteLine("c." + minutes);
                Console.WriteLine("d." + secondstotal);
                Console.WriteLine("e." + milliseconds);

                //זה מחשב משהו, אבל לא מה שצריך.לא מבינה איך לסדר את זה

            }
            else { Console.WriteLine("invalid number"); }
        }
    }
}
