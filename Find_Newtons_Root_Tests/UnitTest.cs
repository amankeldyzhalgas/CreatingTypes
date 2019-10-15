using Find_Newtons_Root;
using NUnit.Framework;

namespace Find_Newtons_Root_Tests
{
    public class UnitTest
    {
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(.004241979, 9, 0.00000001, 0.545)]
        public void UTestFindNthRoot(double number, int degree, double precision, double expected)
        {
            var result = Program.FindNthRoot(number, degree, precision);
            Assert.AreEqual(expected, result, precision);
        }
    }
}