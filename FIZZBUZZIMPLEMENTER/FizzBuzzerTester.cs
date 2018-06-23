using System;

namespace FIZZBUZZIMPLEMENTER
{
    public class FizzBuzzerTester
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FIZZBUZZ";
            if (input % 3 == 0)
                return "FIZZ";
            if (input % 5 == 0)
                return "BUZZ";

            return input.ToString();
        }
    }
}
