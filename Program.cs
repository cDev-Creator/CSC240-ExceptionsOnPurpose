using System;
using static System.Console;

namespace CSC240_04_01_ExceptionsOnPurpose_NGM
{
    class ExceptionsOnPurpose
    {
        static void Main(string[] args)
        {
            //exercise 1
            int answer;
            int result;
            int zero = 0;

            //exercise 2
            try
            {
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());
                result = answer / zero;
            }
            //exercise 3

            catch (FormatException e)
            {
                WriteLine("You did not enter an integer.");
            }
            catch (DivideByZeroException e)
            {
                WriteLine("This is not your fault.");
                WriteLine("You entered the integer correctly.");
                WriteLine("The program divides by zero.");
            }
        }
    }
}
