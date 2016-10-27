using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Logic.Tests
{
    [TestClass]
    public class CalculationsTests
    {
        [TestMethod]
        public void SqrtNewton_2RootOf2Precision00001_141421Returned()
        {
            double expected = Math.Pow(2.0, 1.0 / 2.0);
            expected = Math.Round(expected, 3);
            double actual = SqrtNewtonIntermediateMethod(2, 2, 0.0001, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SqrtNewton_Minus1RootOf100Precision000000000001_ExceptionReturned()
        {
            double actual = SqrtNewtonIntermediateMethod(100, -1, 0.00000000001, 10);
        }

        [TestMethod]
        public void SqrtNewton_100RootOfIntMaxValuePrecision0000001()
        {
            double expected = Math.Pow((double)int.MaxValue, 1.0 / 100.0);
            expected = Math.Round(expected, 5);
            double actual = SqrtNewtonIntermediateMethod(int.MaxValue, 100, 0.000001, 5);
            Assert.AreEqual(expected, actual);
        }

#region Private Methods


        private double SqrtNewtonIntermediateMethod(double source, int power, double precision, int digitsAfterDot)
        {
            double actual = Math.Round(Calculations.SqrtNewton(source, power, precision), digitsAfterDot);
            return actual;
        }


#endregion

    }
}
