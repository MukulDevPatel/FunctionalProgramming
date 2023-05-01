using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class HarmonicNumber
    {
        public static void HarmonicNum()
        {
            Console.WriteLine("Enter the number");
            double output = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                for (double i = 1; i <= num; i++)
                {
                    output += 1 / i;
                    Console.WriteLine("1/" + i);
                }
                Console.WriteLine("Value of Harmonic Number: " + output);
            }
        }
    }
}
