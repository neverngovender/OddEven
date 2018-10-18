using System.Globalization;

namespace OddEven
{
    public class OddEven
    {
        public static string Print(int number)
        {
            var result = number % 2 == 0 ? "Even" : "Odd";

            if (IsPrime(number))
                result = number.ToString();

            return result;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
