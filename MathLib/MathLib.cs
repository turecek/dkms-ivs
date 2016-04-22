using System;

/// 
/// @mainpage IVS - Calculator
/// @authors Dominik Tureček, Štěpán Vích, Monika Mužikovská, Katka Šmajzrová
/// @brief Program napsaný v jazyce C# do předmětu IVS. Obsahuje grafické prostředí, které komunikuje s matematickou knihovnou a jednotkové testy. Celý projekt je řádně zdokumentován. 
/// @version 1.0
/// @copyright GNU Public License.
/// @date Apr 2016
/// 

/// 
/// @file MathLib.cs	
/// @authors Dominik Tureček, Štěpán Vích, Monika Mužikovská, Katka Šmajzrová
/// @brief Obsahuje základní matematické funkce jako sčítání, odčítání, násobení a dělení a navíc funkce faktoriálu, převodu na binární čísla a funkci mocniny. Všechny funkce jsou voláný především z GUI.
/// @date Apr 2016
/// @copyright GNU Public License. 
///


/// 
/// \defgroup mathLib Math Library
/// @brief Matematická knihovna se zakladnimi a pokročilými matematickými funkcemi.
/// \defgroup simpleOp Simple Math Operations
/// @brief Jednoduché matematické operace, jako plus, mínus, násobení, dělení.
/// \defgroup compOp Complicated Math Operations 
/// @brief Složitější matematické operace jako faktoriál nebo převody do jiných soustav.

/// Prostor jmen matematické knihovny.
namespace MathLibNS
{


    /// Třída obsahující veřejné metody pro jednotlivé matematické operace.
    public class MathLib
    {

		/// 
		/// \addtogroup mathLib
		/// @{
		///


		/// 
		/// \addtogroup simpleOp
		/// @{
		///

        /// @brief Sečte oba argumenty.
        /// @param[in] a Sčítanec a
        /// @param[in] b Sčítanec b
        /// @return a + b
        // Function Plus adds up two arguments. 
        public static double Plus(double a, double b)
        {
            double result = a + b;
            return result;
        }

        /// @brief Odečte argument b od argumentu a.
        /// @param[in] a Menšenec
        /// @param[in] b Menšitel
        /// @return a - b
        // Function Minus subtracts argument b from argument a. 
        public static double Minus(double a, double b)
        {
            double result = a - b;
            return result;
        }
        /// @brief Vynásobí oba argumenty.
        /// @param[in] a Činitel a
        /// @param[in] b Činitel b
        /// @return a * b 
        // Function Multiply multiplies two arguments.
        public static double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        /// @brief Vydělí argument a argumentem b.
        /// @param[in] a Dělenec a
        /// @param[in] b Dělitel b
        /// @pre b != 0
        /// @return a / b 
        // Function Divide divides argument a by argument b.
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Divide by zero.");
            }
            double result = a / b;
            return result;
        }


		/// 
		/// @} Konec simpleOp */
		///

		/// 
		/// \addtogroup compOp
		/// @{
		///

        /// @brief Vrátí faktoriál parametru input.
        /// @param[in] input Přirozené číslo
        /// @pre input >= 0
        /// @return !input
        // Function Factorial returns factorial of input. 
        public static int Factorial(int input)
        {
            int result = 1;
            int tmp = 1;

            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("Input is less than zero.");
            }

            for (int i = input; i > 0; i--)
            {
                 tmp = result;
                 result = result * i;
                 if (tmp > result)
                {
                    throw new OverflowException("Result is out of range.");
                }
            }

            return result;

        }
        /// @brief Umocní argument a argumentem b.
        /// @param[in] a Základ mocniny
        /// @param[in] b Exponent
        /// @pre b > 0
        /// @return a^b 
        // Function Pow counts argument a raised to the power b.
        public static double Pow(double a, int b)
        {
            if (b < 0)
            {
                throw new ArgumentOutOfRangeException("Exponent is less or equal zero.");
            }
            double result = 1;

            for (int i = b; i > 0; i--)
            {
                result = result * a;
            }

            return result;
        }
        /// @brief Převede decimální číslo na binární.
        /// @param[in] a Číslo v decimálním tvaru.
        /// @pre a >= 0
        /// @return Binárni hodnota čísla.
        // Function DecToBin converts decimal argument a to binary result.
        public static long DecToBin(int a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("Decimal number is less than zero.");
            }

            int cipher;
            string value = "";
            while (a > 0)
            {
                cipher = a % 2;
                value = cipher.ToString() + value;
                a = a / 2;
            }
            value = "0" + value;
            long result;
            if (!long.TryParse(value, out result))
            {
                throw new OverflowException("Binary number is out of range.");
            }
            else
            {
                return result;
            }
        }

		/// 
		/// @} Konec compOp */
		///
		/// 
		/// @} Konec MathLib */
		///

    }

}
