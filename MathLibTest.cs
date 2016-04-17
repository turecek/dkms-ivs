using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibNS;

namespace MathTestNS
{
    [TestClass]
    public class MathTest
    {
        // PLUS 
        // Tests if Plus method returns valid results
        [TestMethod]
        public void Plus_Test()
        {
            // arrange
            double input1a = 0.0;
            double input1b = 37.3;
            double input2a = -12.83;
            double input2b = 0.0;
            double input3a = 1024.375;
            double input3b = 123456.01;
            double input4a = 7.3;
            double input4b = -8.0;

            double expected1 = 37.3;
            double expected2 = -12.83;
            double expected3 = 124480.385;
            double expected4 = -0.7;

            // act
            double result1 = MathLib.Plus(input1a, input1b);
            double result2 = MathLib.Plus(input2a, input2b);
            double result3 = MathLib.Plus(input3a, input3b);
            double result4 = MathLib.Plus(input4a, input4b);

            // assert
            Assert.AreEqual(expected1, result1, 1E-10, "Wrong output in Plus method.");
            Assert.AreEqual(expected2, result2, 1E-10, "Wrong output in Plus method.");
            Assert.AreEqual(expected3, result3, 1E-10, "Wrong output in Plus method.");
            Assert.AreEqual(expected4, result4, 1E-10, "Wrong output in Plus method.");
        }

        // MINUS 
        // Tests if Minus method returns valid results
        [TestMethod]
        public void Minus_Test()
        {
            // arrange
            double input1a = 1753.01;
            double input1b = 0;
            double input2a = 7.333;
            double input2b = -2.667;
            double input3a = 10000000;
            double input3b = 0.001;
            double input4a = -100005.3;
            double input4b = -100006.3;

            double expected1 = 1753.01;
            double expected2 = 10.0;
            double expected3 = 9999999.999;
            double expected4 = 1.0;

            // act
            double result1 = MathLib.Minus(input1a, input1b);
            double result2 = MathLib.Minus(input2a, input2b);
            double result3 = MathLib.Minus(input3a, input3b);
            double result4 = MathLib.Minus(input4a, input4b);

            // assert
            Assert.AreEqual(expected1, result1, 1E-10, "Wrong output in Minus method.");
            Assert.AreEqual(expected2, result2, 1E-10, "Wrong output in Minus method.");
            Assert.AreEqual(expected3, result3, 1E-10, "Wrong output in Minus method.");
            Assert.AreEqual(expected4, result4, 1E-10, "Wrong output in Minus method.");
        }
        	
        // MULTIPLY
        // Tests if Multiply method returns valid results
        [TestMethod]
        public void Multiply_Test()
        {
            // arrange
            double input1a = 0.0;
            double input1b = 4562132154.0;
            double input2a = -3.3333;
            double input2b = 3.0;
            double input3a = 1.0E4;
            double input3b = 333.0;
            double input4a = 10000000.0;
            double input4b = -250.0;

            double expected1 = 0.0;
            double expected2 = -9.9999;
            double expected3 = 3330000.0;
            double expected4 = -2500000000.0;

            // act
            double result1 = MathLib.Multiply(input1a, input1b);
            double result2 = MathLib.Multiply(input2a, input2b);
            double result3 = MathLib.Multiply(input3a, input3b);
            double result4 = MathLib.Multiply(input4a, input4b);

            // assert
            Assert.AreEqual(expected1, result1, 1E-10, "Wrong output in Multiply method.");
            Assert.AreEqual(expected2, result2, 1E-10, "Wrong output in Multiply method.");
            Assert.AreEqual(expected3, result3, 1E-10, "Wrong output in Multiply method.");
            Assert.AreEqual(expected4, result4, 1E-10, "Wrong output in Multiply method.");
        }

        // DIVIDE
        // Tests if Divide method returns valid results
        [TestMethod]
        public void Divide_Test()
        {
            // arrange
            double input1a = 0.0;
            double input1b = 4562132154.0;
            double input2a = 1.0E5;
            double input2b = 333.0;
            double input3a = -21850.2216;
            double input3b = 256.458;
            double input4a = -182.9;
            double input4b = -0.236;
                        
            double expected1 = 0.0;
            double expected2 = 300.3003003003;
            double expected3 = -85.2;
            double expected4 = 775.0;

            // act
            double result1 = MathLib.Divide(input1a, input1b);
            double result2 = MathLib.Divide(input2a, input2b);
            double result3 = MathLib.Divide(input3a, input3b);
            double result4 = MathLib.Divide(input4a, input4b);

            // assert
            Assert.AreEqual(expected1, result1, 1E-10, "Wrong output in Divide method.");
            Assert.AreEqual(expected2, result2, 1E-10, "Wrong output in Divide method.");
            Assert.AreEqual(expected3, result3, 1E-10, "Wrong output in Divide method.");
            Assert.AreEqual(expected4, result4, 1E-10, "Wrong output in Divide method.");
        }

        // Tests if Divide method throws an exception for b = 0
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Divide_ByZero_ShouldThrowException()
        {
            // arrange
            double input1a = 250.0;
            double input1b = 0.0;

            // act
            double result = MathLib.Divide(input1a, input1b);

            // assert is handled by ExpectedException
        }
    }
}
