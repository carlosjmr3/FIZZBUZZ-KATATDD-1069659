using FIZZBUZZIMPLEMENTER1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void ARRAY_RETURNS_NUMBER_1()
        {

            int input = 1;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("1", output);

        }

        [TestMethod]
        public void ARRAY_RETURNS_NUMBER_2_WHEN_2()
        {
            int input = 2;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("2", output);
        }
        [TestMethod]
        public void ARRAY_RETURNS_NUMBER_7_WHEN_7()
        {
            int input = 7;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("7", output);
        }
        [TestMethod]
        public void ARRAY_RETURNS_NUMBER_8_WHEN_8()
        {
            int input = 8;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("8", output);
        }
        [TestMethod]
        public void ARRAY_RETURNS_NUMBER_11_WHEN_11()
        {
            int input = 11;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("11", output);
        }
        [TestMethod]
        public void ARRAY_RETURNS_NUMBER_13_WHEN_13()
        {
            int input = 13;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("13", output);
        }
        [TestMethod]
        public void ARRAY_RETURNS_NUMBER_14_WHEN_14()
        {
            int input = 14;
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("14", output);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(50)]
        public void ARRAY_RETURNS_BUZZ_WHEN_NUMBERS_ARE_DIVISIBLE_BY_5(int input)
        {
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("BUZZ", output);

        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]

        public void ARRAY_RETURNS_FIZZ_WHEN_NUMBERS_ARE_DIVISIBLE_BY_3(int input)
        {
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("FIZZ", output);
        }

        [TestMethod]
        [DataRow(30)]
        [DataRow(60)]
        public void ARRAY_RETURNS_FIZZBUZZ_WHEN_NUMBERS_ARE_DIVISIBLE_BY_3_AND_5(int input)
        {
            string output = FizzBuzzerTester.GetValue(input);
            Assert.AreEqual("FIZZBUZZ", output);
        }


    }
}
