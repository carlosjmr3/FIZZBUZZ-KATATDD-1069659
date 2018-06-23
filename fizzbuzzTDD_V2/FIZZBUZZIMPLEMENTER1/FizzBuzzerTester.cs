using System;

namespace FIZZBUZZIMPLEMENTER1
{
    public class FizzBuzzerTester
    {
        public static string GetValue(int input)
        {

            if (FizzBuzz(input))
            {
                return "FIZZBUZZ";
            }
            else if (Buzz(input))
            {
                return "BUZZ";
            }
            else if (Fizz(input))
            {
                return "FIZZ";
            }

            return input.ToString();
        }

        public static bool FizzBuzz(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool Buzz(int input)
        {
            if (input % 5 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool Fizz(int input)
        {
            if (input % 3 == 0)
            {
                return true;
            }
            return false;
        }
    }
    }

