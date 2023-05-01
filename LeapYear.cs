using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LeapYear
    {
        public void CheckLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("{0} is Leap year.", year);
            else
                Console.WriteLine("{0} is not Leap year.", year);
        }
    }
}
