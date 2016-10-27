using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4.Logic;

namespace Task4.Logic.Test
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void ToBinaryString_doubleMaxValue_BinaryStringReturned()
        {
            string expected = "0111111111101111111111111111111111111111111111111111111111111111";
            string actual = double.MaxValue.ToBinaryString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToBinaryString_5_5InBinaryReturned()
        {
            string expected = "0100000000010100000000000000000000000000000000000000000000000000";
            string actual = (5.0).ToBinaryString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToBinaryString_doubleMinValue_5InBinaryReturned()
        {
            string expected = "1111111111101111111111111111111111111111111111111111111111111111";
            string actual = double.MinValue.ToBinaryString();
            Assert.AreEqual(expected, actual);
        }

    }
}
