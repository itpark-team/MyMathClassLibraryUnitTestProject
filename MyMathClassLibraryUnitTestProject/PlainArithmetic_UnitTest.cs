using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyMathClassLibrary;

namespace MyMathClassLibraryUnitTestProject
{
    [TestClass]
    public class PlainArithmetic_UnitTest
    {
        [TestMethod]
        public void Sum_input_3_5_output_8()
        {
            PlainArithmetic plainArithmetic = new PlainArithmetic();

            double expected = 8;
            
            double actual = plainArithmetic.Sum(3, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mul_input_2_2_output_4()
        {
            PlainArithmetic plainArithmetic = new PlainArithmetic();

            double expected = 4;

            double actual = plainArithmetic.Mul(2, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
