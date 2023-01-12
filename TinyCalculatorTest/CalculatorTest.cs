using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TinyCalculator;

namespace TinyCalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calculator = new Calculator();
        }

        [TestMethod]
        public void TestInvalididInput()
        {
            Calculator calculator = new Calculator();
            try
            {
                int result = calculator.Calculate("abcd");
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }
        void DoSumTest(string input, int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Calculate(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OnePlusOne()
        {
            DoSumTest("1+1", 2); ;
        }


        [TestMethod]
        public void TwoPlusTwo()
        {
            DoSumTest("2+2", 4);
        }
        [TestMethod]
        public void FourPlusEleven()
        {
            DoSumTest("4+11", 15);
        }
        [TestMethod]
        public void TwoMinusOne()
        {
            DoSumTest("2-1", 1);
        }
        [TestMethod]
        public void FiveMinusTwo()
        {
            DoSumTest("5-2", 3);
        }
        [TestMethod]
        public void FiveTimesTwo()
        {
            DoSumTest("5*2", 10);
        }
        [TestMethod]
        public void EightDivideByTwo()
        {
            DoSumTest("8/2", 4);
        }



    }
}
