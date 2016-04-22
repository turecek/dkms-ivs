using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLibNS;

/// 
/// @file CalcForm.cs    
/// @authors Dominik Tureček, Štěpán Vích, Monika Mužikovská, Katka Šmajzrová
/// @brief Obsahuje funkce, které jsou navázány na eventy v GUI. Obsahuje i funkce zodpovědné za zobrazování výstupu kalkulačky a další pomocné funkce.
/// @date Apr 2016
/// @copyright GNU Public License. 
///

/// \defgroup guiFc GUI Class
/// @brief Contain methods that are linked with GUI events.


/// Prostor jmen grafického prostředí.
namespace Calc
{

    
    /// Třída obsahující metody, které se vážou na eventy v GUI, vypočítávájí výsledek a zobrazují ho.
    public partial class CalcForm : Form
    {


        /// 
        /// \addtogroup guiFc
        /// @{
        ///

        // Variables used as paramethers in methods from MathLibNS
        double var1; ///< Proměnná a předávaná jako parametr do matematické knihovny.
        double var2; ///< Proměnná b předávaná jako parametr do matematické knihovny.       
        double result; ///< Výsledek funkcí matematické knihovny.
        // String used for determining which operator was used
        string lastOp = "";
        // When bool op is true, textbox1 will clear after next numbered button is pressed
        bool op = false;
        // When there is an error message in textbox1, bool error is true
        bool error = false;

        /// @brief Konstruktor třídy
        /// @return void
        public CalcForm()
        {
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        // Method calls functions from MathLib depending on which operator was used
        /// @brief Method calls functions from MathLib depending on which operator was used
        /// @param[in] a Vstupní hodnota a
        /// @param[in] b Vstupní hodnota b
        /// @return void 
        public void LastOperation(double a, double b)
        {
            switch (lastOp)
            {
                case "plus":
                    result = MathLib.Plus(a, b);
                    lastOp = "";
                    break;
                case "minus":
                    result = MathLib.Minus(a, b);
                    lastOp = "";
                    break;
                case "multiply":
                    result = MathLib.Multiply(a, b);
                    lastOp = "";
                    break;
                case "divide":
                    try
                    {
                        result = MathLib.Divide(a, b);
                    }
                    catch(Exception)
                    {
                        textBox1.Text = "Nulou nelze delit.";
                        error = true;
                    }
                    lastOp = "";
                    break;
                case "pow":
                    int exponent;
                    if (!Int32.TryParse(b.ToString(), out exponent))
                    {
                        textBox1.Text = "Neplatny vstup";
                        error = true;
                    }
                    else
                    {
                        try
                        {
                            result = MathLib.Pow(a, exponent);
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            textBox1.Text = "Zaporny exponent.";
                            error = true;
                        }
                    }
                    lastOp = "";
                    break;
            }
        }
        
        // Method handling pressing of an operator button
        /// @brief Method handling pressing of an operator button
        /// @return void
        public void ButtonClick(string operation)
        {
            if (lastOp == "")
            {
                lastOp = operation;

                if (!Double.TryParse(textBox1.Text, out var1))
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
                else
                {
                    op = true;
                }
            }

            else
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
                else
                {
                    LastOperation(var1, var2);
                    if (!error)
                    {
                        textBox1.Text = result.ToString();
                        var1 = result;
                        lastOp = operation;
                        op = true;
                    }
                }
            }
        }

        // DecToBin
        private void DecToBin_Click(object sender, EventArgs e)
        {
            int res;

            if (lastOp == "")
            {
                if (Int32.TryParse(textBox1.Text, out res))
                {
                    textBox1.Text = MathLib.DecToBin(res).ToString();
                }
                else
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
            }

            else
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
                else
                {
                    LastOperation(var1, var2);
                    if (Int32.TryParse(result.ToString(), out res))
                    {
                        try
                        {
                            textBox1.Text = MathLib.DecToBin(res).ToString();
                        }
                        catch (OverflowException)
                        {
                            textBox1.Text = "Prilis velke cislo.";
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            textBox1.Text = "Zaporne cislo.";
                        }

                    }
                    else
                    {
                        textBox1.Text = "Neplatny vstup";
                        error = true;
                    }
                 }

            }
            op = true;
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            ButtonClick("pow");
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            int res;

            if (lastOp == "")
            {
                if (Int32.TryParse(textBox1.Text, out res))
                {
                    try
                    {
                        textBox1.Text = MathLib.Factorial(res).ToString();
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        textBox1.Text = "Faktorial neexistuje.";
                    }
                    catch(OverflowException)
                    {
                        textBox1.Text = "Prilis velke cislo.";
                    }
                }
                else
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
            }

            else
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
                else
                {
                    LastOperation(var1, var2);
                    if (Int32.TryParse(result.ToString(), out res))
                    {
                        textBox1.Text = MathLib.Factorial(res).ToString();
                    }
                    else
                    {
                        textBox1.Text = "Neplatny vstup";
                        error = true;
                    }
                }

            }
            op = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ButtonClick("plus");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            ButtonClick("minus");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            ButtonClick("multiply");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            ButtonClick("divide");
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            error = false;
            
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            var1 = var2 = 0;
            result = 0;
            textBox1.Text = "0";
            op = false;
            lastOp = "";
            error = false;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (lastOp != "")
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                {
                    textBox1.Text = "Neplatny vstup";
                    error = true;
                }
                else
                {
                    LastOperation(var1, var2);
                    if (!error)
                    {
                        textBox1.Text = result.ToString();
                        var1 = result;
                        lastOp = "";
                    }
                }
            }
            op = true;
        }

        private void NumberClick(string number)
        {
            if ((textBox1.Text == "0") || (error) || (op))
            {
                textBox1.Text = number;
                error = false;
                op = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + number;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberClick("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberClick("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberClick("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberClick("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberClick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberClick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberClick("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberClick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberClick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberClick("9");
        }

        private void buttonDecPoint_Click(object sender, EventArgs e)
        {
            bool point = false;

            foreach (char c in textBox1.Text)
            {
                if (c == ',')
                {
                    point = true;
                }
            }

            if ((!point) && (!error) && (!op))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
        /// 
        /// @} Konec guiFc */
        ///         
    }
}
