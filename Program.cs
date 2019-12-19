using System;
using static System.Console;

namespace metric_to_imperial
{
    class Program
    {
        // use class-level static variables, since
        // we are not instantiating objects (yet!)
        static double meters;
        static int totalInches,
                   feet,
                   inches;
        static void Main(string[] args)
        {
            ReadInt("How many meters?");
            WriteLine("Hello World!");
        }
        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0} {1} ", "Invalid input!", label);
                userInput = ReadLine();
            }
            return number;
        }
    }
}
