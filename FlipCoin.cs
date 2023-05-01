using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FlipCoin
    {
        public static void DisplayFlipPercent()
        {
            Console.WriteLine("Enter the number of flips");

            int Head = 0, Tail = 0;
            int HeadCount = 0, TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipcoin = Convert.ToInt32(Console.ReadLine());
            if (flipcoin >= 0)
            {
                for (int i = 1; i <= flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The Random function is " + number);
                    switch (number)
                    {
                        case 1:
                            HeadCount++;
                            break;
                        case 0:
                            TailCount++;
                            break;
                    }
                }
                Console.WriteLine("The Head Count is " + HeadCount);
                Console.WriteLine("The Tail Count is " + TailCount);

                HeadPercentage = HeadCount * 100 / flipcoin;
                TailPercentage = TailCount * 100 / flipcoin;

                Console.WriteLine("The Head percentage: {0}%", HeadPercentage);
                Console.WriteLine("The Head percentage: " + TailPercentage + "%");
            }
        }
    }
}
