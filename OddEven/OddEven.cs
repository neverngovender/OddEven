using System;

namespace OddEven
{
    public class OddEven
    {
        public static string Print(int number)
        {
            var result = number % 2 == 0 ? "Even" : "Odd";
            return result;
        }
    }
}
