namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functinal Programs");
            Console.WriteLine("Check Leap Year");
            LeapYear leapYear = new LeapYear();
            Console.WriteLine("Enter a number of Year");
            int year =Convert.ToInt32(Console.ReadLine());
            leapYear.CheckLeapYear(year);
        }
    }
}
