using System;

namespace MathLibNS
{
    public class MathLib
    {
        // Function Plus adds up two arguments.
        public static double Plus(double a, double b)
        {
            double result = a + b;
            return result;
        }

        // Function Minus subtracts argument b from argument a.
        public static double Minus(double a, double b)
        {
            double result = a - b;
            return result;
        }

        // Function Multiply multiplies two arguments.
        public static double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

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

        // Function Factorial returns factorial of input.
        public static int Factorial(int input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("Input is less than zero.");
            }

            int result = 1;

            for (int i = input; i > 0; i--)
            {
                result = result * i;
            }

            return result;

        }

        // Function Pow counts argument a raised to the power b.
        public static double Pow(double a, int b)
        {
            if (b <= 0)
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

        // Function DecToBin converts decimal argument a to binary result.
        public static long DecToBin(int a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("Decimal number is less than zero.");
            }

            int cipher;
            string result = "";
            while (a > 0)
            {
                cipher = a % 2;
                result = cipher.ToString() + result;
                a = a / 2;
            }
            result = "0" + result;
            return long.Parse(result);
        }
    }
}
