using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibNS;

namespace MathTestNS
{
	[TestClass]
	public class MathTest
	{
		// POW
		// Tests if Pow method returns valid results
		[TestMethod]
		public void Pow_Test()
		{
			// arange
			double input1a = 5;
			int input1b = 2;
			double input2a = 12;
			int input2b = 3;
			double input3a = 2;
			int input3b = 10;
			double input4a = 18;
			int input4b = 6;
			double input5a = -4;
			int input5b = 3;
			double input6a = -5;
			int input6b = 6;

			double expected1 = 25;
			double expected2 = 1728;
			double expected3 = 1024;
			double expected4 = 34012224;
			double expected5 = -64;
			double expected6 = 15625;

			// act
			double result1 = MathLib.Pow(input1a, input1b);
			double result2 = MathLib.Pow(input2a, input2b);
			double result3 = MathLib.Pow(input3a, input3b);
			double result4 = MathLib.Pow(input4a, input4b);
			double result5 = MathLib.Pow(input5a, input5b);
			double result6 = MathLib.Pow(input6a, input6b);

			// assert
			Assert.AreEqual(expected1, result1, 0, "Wrong output for Pow(5, 2)");
			Assert.AreEqual(expected2, result2, 0, "Wrong output for Pow(12, 3)");
			Assert.AreEqual(expected3, result3, 0, "Wrong output for Pow(2, 10)");
			Assert.AreEqual(expected4, result4, 0, "Wrong output for Pow(18, 6)");
			Assert.AreEqual(expected5, result5, 0, "Wrong output for Pow(-4, 3)");
			Assert.AreEqual(expected6, result6, 0, "Wrong output for Pow(-5, 6)");
		}

		// Tests if pow method throws an exception is second input is less or equal zero
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Pow_InputLEQZero_ShouldThrowArgumentOutOfRange()
		{
		// arrange
		double input1a = -11;
		int input1b = -3;
		double input2a = 6;
		int input2b = -2;

		// act
		double result1 = MathLib.Pow(input1a, input1b);
		double result2 = MathLib.Pow(input2a, input2b);

		// assert is handled by ExpectedException
		}

		// DecToBin
		// Tests if DecToBin method returns valid results
		[TestMethod]
		public void DecToBin_Test()
		{
			// arange
			int input1 = 845;
			int input2 = 102;
			int input3 = 40;
			int input4 = 40076;
			int input5 = 21;
			int input6 = 0;

			long expected1 = 1101001101;
			long expected2 = 1100110;
			long expected3 = 101000;
			long expected4 = 1001110010001100;
			long expected5 = 10101;
			long expected6 = 0;

			// act
			long result1 = MathLib.DecToBin(input1);
			long result2 = MathLib.DecToBin(input2);
			long result3 = MathLib.DecToBin(input3);
			long result4 = MathLib.DecToBin(input4);
			long result5 = MathLib.DecToBin(input5);
			long result6 = MathLib.DecToBin(input6);
			// assert
			Assert.AreEqual(expected1, result1, 0, "Wrong output for DecToBin(845)");
			Assert.AreEqual(expected2, result2, 0, "Wrong output for DecToBin(102)");
			Assert.AreEqual(expected3, result3, 0, "Wrong output for DecToBin(40)");
			Assert.AreEqual(expected4, result4, 0, "Wrong output for DecToBin(40076)");
			Assert.AreEqual(expected5, result5, 0, "Wrong output for DecToBin(21)");
			Assert.AreEqual(expected6, result6, 0, "Wrong output for DecToBin(0)");
		}

		// Tests if DecToBin method throws an exception is argument is less then zero
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void DecToBin_InputLessThenZero_ShouldThrowArgumentOutOfRange()
		{
			// arrange
			int input1 = -11;
			int input2 = -3;

			// act
			long result1 = MathLib.DecToBin(input1);
			long result2 = MathLib.DecToBin(input2);

			// assert is handled by ExpectedException
		}

	}

}