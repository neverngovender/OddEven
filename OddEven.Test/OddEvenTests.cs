using NUnit.Framework;

namespace OddEven.Test
{
    [TestFixture]
    public class OddEvenTests
    {
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

        [TestCase("Even", 2)]
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
    }
}
