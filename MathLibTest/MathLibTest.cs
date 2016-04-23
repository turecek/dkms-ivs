using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibNS;


/// 
/// @file MathLibTest.cs    
/// @authors Dominik Tureček, Štěpán Vích, Monika Mužikovská, Katka Šmajzrová
/// @brief Obsahuje jednotkové testy, pro funkce z matematické knihovny. Funkce využívají modul UnitTesting.
/// @date Apr 2016
/// @copyright GNU Public License. 
///

/// 
/// \defgroup MathTest Math Library Unit Tests
/// @brief Modul obsahující jednotkové testy pro matematickou knihovnu. 
/// \defgroup retTest Return Value Test
/// @brief Testy kontrolující správnost výstupu funkcí.
/// \defgroup exceptTest Exception Throw Test
/// @brief Testy kontrolující zda funkce vyvolávají vyjímky.
///

/// Prostor jmen testů matematické knihovny.
namespace MathTestNS
{
    /// Třída obsahující jednotkové testy pro třídu MathLibNS::MathLib.
    [TestClass]
    public class MathTest
    {

        /// 
        /// \addtogroup MathTest
        /// @{
        ///


        /// 
        /// \addtogroup retTest
        /// @{
        ///


        // PLUS 
        // Tests if Plus method returns valid results
        /// @brief Testuje funkci MathLib.Plus(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#Plus
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
        /// @brief Testuje funkci MathLib.Minus(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#Minus
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
        /// @brief Testuje funkci MathLib.Multply(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#Multiply
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
        /// @brief Testuje funkci MathLib.Divide(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#Divide
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


        /// 
        /// @} Konec retTest */
        ///   

        /// 
        /// \addtogroup exceptTest
        /// @{
        ///

        // Tests if Divide method throws an exception for b = 0
        /// @brief Testuje jestli funkce MathLib.Divide(), vyvolává vyjímku pro b = 0.
        /// @see MathLibNS#MathLib#Divide
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


        /// 
        /// @} Konec exceptTest */
        /// 

        /// 
        /// \addtogroup retTest
        /// @{
        ///


        // FACTORIAL
        // Tests if Factorial method returns valid results
        /// @brief Testuje funkci MathLib.Factorial(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#Factorial
        [TestMethod]
        public void Factorial_ValidInputs()
        {
            // arrange
            int input1 = 0;
            int input2 = 1;
            int input3 = 4;
            int input4 = 10;

            int expected1 = 1;
            int expected2 = 1;
            int expected3 = 24;
            int expected4 = 3628800;

            // act
            int result1 = MathLib.Factorial(input1);
            int result2 = MathLib.Factorial(input2);
            int result3 = MathLib.Factorial(input3);
            int result4 = MathLib.Factorial(input4);

            // assert
            Assert.AreEqual(expected1, result1, 0, "Wrong output for 0 factorial");
            Assert.AreEqual(expected2, result2, 0, "Wrong output for 1 factorial");
            Assert.AreEqual(expected3, result3, 0, "Wrong output for 4 factorial");
            Assert.AreEqual(expected4, result4, 0, "Wrong output for 10 factorial");
        }

        /// 
        /// @} Konec retTest */
        ///   


        /// 
        /// \addtogroup exceptTest
        /// @{
        ///


        // Tests if factorial method throws an exception for input less than zero
        /// @brief Testuje jestli funkce MathLib.Factorial(), vyvolává vyjímku pro input < 0.
        /// @see MathLibNS#MathLib#Factorial
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Factorial_InputLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            int input1 = -42;
            int input2 = -1;

            // act
            int result1 = MathLib.Factorial(input1);
            int result2 = MathLib.Factorial(input2);

            // assert is handled by ExpectedException
        }

        // Tests if factorial method throws an exception when overflow occurs.
        /// @brief Testuje jestli funkce MathLib.Factorial(), vyvolává vyjímku pro případ, kdy nastává overflow.
        /// @see MathLibNS#MathLib#Factorial
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Factorial_InputOverflow_ShouldThrowOverflow()
        {
            // arrange
            int input1 = 23;
            int input2 = 28;

            // act
            int result1 = MathLib.Factorial(input1);
            int result2 = MathLib.Factorial(input2);

            // assert is handled by ExpectedException
        }

        /// 
        /// @} Konec exceptTest */
        /// 


        /// 
        /// \addtogroup retTest
        /// @{
        ///

        // POW
        // Tests if Pow method returns valid results
        /// @brief Testuje funkci MathLib.Pow(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#Pow   
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
            double input7a = 3.6;
            int input7b = 0;

            double expected1 = 25;
            double expected2 = 1728;
            double expected3 = 1024;
            double expected4 = 34012224;
            double expected5 = -64;
            double expected6 = 15625;
            double expected7 = 1;

            // act
            double result1 = MathLib.Pow(input1a, input1b);
            double result2 = MathLib.Pow(input2a, input2b);
            double result3 = MathLib.Pow(input3a, input3b);
            double result4 = MathLib.Pow(input4a, input4b);
            double result5 = MathLib.Pow(input5a, input5b);
            double result6 = MathLib.Pow(input6a, input6b);
            double result7 = MathLib.Pow(input7a, input7b);

            // assert
            Assert.AreEqual(expected1, result1, 0, "Wrong output for Pow(5, 2)");
            Assert.AreEqual(expected2, result2, 0, "Wrong output for Pow(12, 3)");
            Assert.AreEqual(expected3, result3, 0, "Wrong output for Pow(2, 10)");
            Assert.AreEqual(expected4, result4, 0, "Wrong output for Pow(18, 6)");
            Assert.AreEqual(expected5, result5, 0, "Wrong output for Pow(-4, 3)");
            Assert.AreEqual(expected6, result6, 0, "Wrong output for Pow(-5, 6)");
            Assert.AreEqual(expected7, result7, 0, "Wrong output for Pow(3.6, 0)");
        }


        /// 
        /// @} Konec retTest */
        ///   

        /// 
        /// \addtogroup exceptTest
        /// @{
        ///

        // Tests if pow method throws an exception is second input is less or equal zero
        /// @brief Testuje jestli funkce MathLib.Pow(), vyvolává vyjímku pokud je exponent <= 0.
        /// @see MathLibNS#MathLib#Pow   
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

        /// 
        /// @} Konec exceptTest */
        /// 

        /// 
        /// \addtogroup retTest
        /// @{
        ///

        // DecToBin
        // Tests if DecToBin method returns valid results
        /// @brief Testuje funkci MathLib.DecToBin(), zda vrací správné hodnoty.
        /// @see MathLibNS#MathLib#DecToBin 
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

        /// 
        /// @} Konec retTest */
        ///    

        /// 
        /// \addtogroup exceptTest
        /// @{
        ///


        // Tests if DecToBin method throws an exception is argument is less then zero
        /// @brief Testuje jestli funkce MathLib.DecToBin(), vyvolává vyjímku pokud je argumnet < 0.
        /// @see MathLibNS#MathLib#DecToBin 
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


        /// 
        /// @} Konec exceptTest */
        /// 

        // Tests if DecToBin method throws an exception when overflow occurs.
        /// @brief Testuje jestli funkce MathLib.DecToBin(), vyvolává vyjímku pro případ, kdy nastává overflow.
        /// @see MathLibNS#MathLib#DecToBin
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void DecToBin_InputOverflow_ShouldThrowOverflow()
        {
            // arrange
            int input1 = 1000000;
            int input2 = 2500000;

            // act
            long result1 = MathLib.DecToBin(input1);
            long result2 = MathLib.DecToBin(input2);

            // assert is handled by ExpectedException
        }

        /// 
        /// @} Konec exceptTest */
        /// 


        /// 
        /// @} Konec MathTest */
        ///


    }
}
