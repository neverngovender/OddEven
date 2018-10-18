using NUnit.Framework;

namespace OddEven.Test
{
    [TestFixture]
    public class OddEvenTests
    {
        [TestCase("Odd", 1)]
        [TestCase("Odd", 9)]
        [TestCase("Odd", 15)]
        [TestCase("Odd", 27)]
        [TestCase("Odd", 33)]
        [TestCase("Odd", 39)]
        [TestCase("Odd", 45)]
        public void Given_an_odd_number_return_string_Odd(string expected, int number)
        {
            var result = OddEven.Print(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase("Even", 4)]
        [TestCase("Even", 6)]
        [TestCase("Even", 8)]
        [TestCase("Even", 10)]
        [TestCase("Even", 12)]
        public void Given_an_even_number_return_string_Even(string expected, int number)
        {
            var result = OddEven.Print(number);
            Assert.AreEqual(expected, result);
        }

        [TestCase("2", 2)]
        [TestCase("3", 3)]
        [TestCase("5", 5)]
        [TestCase("7", 7)]
        [TestCase("11", 11)]
        [TestCase("13", 13)]
        public void Given_a_prime_number_return_number(string expected, int number)
        {
            var result = OddEven.Print(number);
            Assert.AreEqual(expected, result);
        }
    }
}
