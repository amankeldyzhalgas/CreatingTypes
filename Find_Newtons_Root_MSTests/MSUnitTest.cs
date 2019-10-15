using Find_Newtons_Root;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Find_Newtons_Root_MSTests
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindNthRoot_minus0point01_2_0point0001_ArgumentException()
        {
            double number = -0.01;
            int degree = 2;
            double precision = 0.0001;
            double expectedResult = -1;
            double result = Program.FindNthRoot(number, degree, precision);

            Assert.AreEqual(expectedResult, result, precision);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindNthRoot_0point001_minus2_0point0001_ArgumentException()
        {
            double number = 0.001;
            int degree = -2;
            double precision = 0.0001;
            double expectedResult = -5;
            double result = Program.FindNthRoot(number, degree, precision);

            Assert.AreEqual(expectedResult, result, precision);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindNthRoot_0point01_2_minus1_ArgumentException()
        {
            double number = 0.01;
            int degree = 2;
            double precision = -1;
            double expectedResult = -4;
            double result = Program.FindNthRoot(number, degree, precision);

            Assert.AreEqual(expectedResult, result, precision);
        }
    }
}
