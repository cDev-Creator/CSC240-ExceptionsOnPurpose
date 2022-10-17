﻿using System;
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

            Write("Enter an integer >> ");
            answer = Convert.ToInt32(ReadLine());

            result = answer / zero;
            WriteLine("The answer is " + answer);
            
            //exercise 2
            try
            {
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());
                result = answer / zero;
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            
        }
    }
}
