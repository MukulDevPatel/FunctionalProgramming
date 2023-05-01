using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class SwapNumber
    {
        public static void SwapNum()
        {
            Console.WriteLine("Enter value a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swaping\na = " + a + "\nb = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swaping\na = " + a + "\nb = " + b);
        }
    }
}
