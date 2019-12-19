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
            meters = ReadDouble("How many meters?");
            totalInches = (int)MetersToInches(meters);
            InchesToFeet();
            WriteLine(FormatOutput());
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
        static double MetersToInches(double m)
        {
            return m * (1 / 0.0254);
        }
        static void InchesToFeet()
        {
            feet = totalInches / 12;
            inches = totalInches % 12;
        }
        static string FormatOutput()
        {
            string result = String.Format("****** Metric to Imperial ******\n");
            result += String.Format("* {0, 15} {1, 12:N} *\n", "Meters:", meters);
            result += String.Format("* {0, 15} {1, 12:N0} *\n", "Total Inches:", totalInches);
            result += String.Format("* {0, 15} {1, 12:N0} *\n", "Feet:", feet);
            result += String.Format("* {0, 15} {1, 12:N0} *\n", "Inches:", inches);
            result += String.Format("********************************\n");
            return result;
        }
    }
}
