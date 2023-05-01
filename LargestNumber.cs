using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LargestNumber
    {
        public static void LargestNum()
        {
            Console.WriteLine("Enter 1st Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 >num3)
            {
                Console.WriteLine("The 1st number is greatest among three");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("The 2nd number is greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is greatest among three");
            }
        }
    }
}
