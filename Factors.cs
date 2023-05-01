using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Factors
    {
        public static void PrimeFactor()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }
            if (num > 1)
                Console.WriteLine(num);
        }
    }
}
