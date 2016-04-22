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

namespace Calc
{
    public partial class CalcForm : Form
    {
        // Variables used as paramethers for methods from MathLibNS
        double var1;
        double var2;
        
                
        double result;

        // String used for determining which operator was used
        string lastOp = "";

        // When bool op is true, textbox1 will clear after next numbered button is pressed
        bool op = false;

        // When there is an error message in textbox1, bool error is true
        bool error = false;

        // Two initializing methods
        public CalcForm()
        {
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }
      

        // Method calls functions from MathLib depending on which operator was used
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
                    // Library throws an exception in case of dividing by zero, which
                    // is handled in section catch
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

        // Method calling particular library method according to pressed operation button 
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

        // Method handling pressing of an DecToBin button
        // Because of one operand, it calls an library method directly
        private void DecToBin_Click(object sender, EventArgs e)
        {
            int res;

            if (lastOp == "")
            {
                if (Int32.TryParse(textBox1.Text, out res))
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

        // Method handling pressing of a Power button 
        private void buttonPow_Click(object sender, EventArgs e)
        {
            ButtonClick("pow");
        }

        // Method handling pressing of a Factorial button
        // Because of one operand, it calls an library method directly
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
                        try
                        {
                            textBox1.Text = MathLib.Factorial(res).ToString();
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            textBox1.Text = "Faktorial neexistuje.";
                        }
                        catch (OverflowException)
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

            }
            op = true;
        }

        // Method handling pressing of a Plus button
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ButtonClick("plus");
        }

        // Method handling pressing of a Minus button
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            ButtonClick("minus");
        }

        // Method handling pressing of a Multiply button
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            ButtonClick("multiply");
        }

        // Method handling pressing of a Divide button
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            ButtonClick("divide");
        }

        // Method handling pressing of a CE button
        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            error = false;
            
        }

        // Method handling pressing of a C button
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            var1 = var2 = 0;
            result = 0;
            textBox1.Text = "0";
            op = false;
            lastOp = "";
            error = false;
        }

        // Method handling pressing of an Equals button
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

        // Method handling writing to textbox according to pressed numbered button
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

        // Method handling pressing of a 0 numbered button
        private void button0_Click(object sender, EventArgs e)
        {
            NumberClick("0");
        }

        // Method handling pressing of a 1 numbered button
        private void button1_Click(object sender, EventArgs e)
        {
            NumberClick("1");
        }

        // Method handling pressing of a 2 numbered button
        private void button2_Click(object sender, EventArgs e)
        {
            NumberClick("2");
        }

        // Method handling pressing of a 3 numbered button
        private void button3_Click(object sender, EventArgs e)
        {
            NumberClick("3");
        }

        // Method handling pressing of a 4 numbered button
        private void button4_Click(object sender, EventArgs e)
        {
            NumberClick("4");
        }

        // Method handling pressing of a 5 numbered button
        private void button5_Click(object sender, EventArgs e)
        {
            NumberClick("5");
        }

        // Method handling pressing of a 6 numbered button
        private void button6_Click(object sender, EventArgs e)
        {
            NumberClick("6");
        }

        // Method handling pressing of a 7 numbered button
        private void button7_Click(object sender, EventArgs e)
        {
            NumberClick("7");
        }

        // Method handling pressing of a 8 numbered button
        private void button8_Click(object sender, EventArgs e)
        {
            NumberClick("8");
        }

        // Method handling pressing of a 9 numbered button
        private void button9_Click(object sender, EventArgs e)
        {
            NumberClick("9");
        }

        // Method handling pressing of a decimal point button
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
    }
}
