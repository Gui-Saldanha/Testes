using NUnit.Framework;

namespace UnitTest
{
    public class UnitTest
    {
        Function.Function function = new Function.Function();

        private Dictionary<int, string[]> outInput = new Dictionary<int, string[]>
        {
            { 1, new[] { "1" } },
            { 2, new[] { "1", "2" } },
            { 3, new[] { "1", "2", "Fizz" } },
            { 4, new[] { "1", "2", "Fizz", "4" } },
            { 5, new[] { "1", "2", "Fizz", "4", "Buzz" } },
            { 6, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz" } },
            { 7, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" } },
            { 8, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8" } },
            { 9, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz" } },
            { 10, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" } },
            { 11, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11" } },
            { 12, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz" } },
            { 13, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13" } },
            { 14, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14" } },
            { 15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } }
        };

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        public void TestFizzBuzz(int numberFizzBuzz)
        {
            //Act
            var result = function.FizzBuzz(numberFizzBuzz).ToArray();

            //Assert
            var outWaited = outInput[numberFizzBuzz];

            Assert.AreEqual(result.Length, outWaited.Length);

            for (int i = 0; i < outWaited.Length; i++)
            {
                Assert.AreEqual(result[i], outWaited[i]);
            }
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void TestNumbersRomans(string numberRoman, int numberIntegerWaited)
        {
            //Act
            var result = function.NumbersRomansToInt(numberRoman);

            //Assert
            Assert.AreEqual(numberIntegerWaited, result);
        }
    }
}