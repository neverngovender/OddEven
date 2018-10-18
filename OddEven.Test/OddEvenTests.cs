using NUnit.Framework;

namespace OddEven.Test
{
    [TestFixture]
    public class OddEvenTests
    {
        [TestCase("Odd", 1)]
        [TestCase("Odd", 3)]
        [TestCase("Odd", 5)]
        [TestCase("Odd", 7)]
        [TestCase("Odd", 9)]
        [TestCase("Odd", 11)]
        public void Given_an_odd_number_return_string_Odd(string expected, int number)
        {
            var result = OddEven.Print(number);
            Assert.AreEqual(expected, result);
        }
    }
}
