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
        // Variables used as paramethers in methods from MathLibNS
        double var1;
        double var2;        
        double result;
        // String used for determining which operator was used
        string lastOp = "";
        // When bool op is true, textbox1 will clear after next numbered button is pressed
        bool op = false;

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
                    result = MathLib.Divide(a, b);
                    lastOp = "";
                    break;
                case "pow":
                    int exponent;
                    if (Int32.TryParse(b.ToString(), out exponent))
                    {
                        result = MathLib.Pow(a, exponent);
                    }
                    else
                        textBox1.Text = "Neplatny vstup";
                    lastOp = "";
                    break;
            }
        }

        // Method handling pressing of an operator button
        public void ButtonClick(string operation)
        {
            if (lastOp == "")
            {
                lastOp = operation;

                if (!Double.TryParse(textBox1.Text, out var1))
                    textBox1.Text = "Neplatny vstup";
                else
                    op = true;
            }

            else
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                    textBox1.Text = "Neplatny vstup";
                else
                {
                    LastOperation(var1, var2);
                    textBox1.Text = result.ToString();
                    var1 = result;
                    lastOp = operation;
                    op = true;
                }
            }
        }

        public CalcForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        // DecToBin
        private void button10_Click_1(object sender, EventArgs e)
        {
            int res;

            if (lastOp == "")
            {
                if (Int32.TryParse(textBox1.Text, out res))
                    textBox1.Text = MathLib.DecToBin(res).ToString();
                else
                    textBox1.Text = "Neplatny vstup";
            }

            else
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                    textBox1.Text = "Neplatny vstup";
                else
                {
                    LastOperation(var1, var2);
                    if (Int32.TryParse(result.ToString(), out res))
                    {
                        textBox1.Text = MathLib.DecToBin(res).ToString();
                        var1 = Double.Parse(textBox1.Text);
                    }
                    else
                        textBox1.Text = "Neplatny vstup";
                }

            }
            op = true;
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

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
                    textBox1.Text = MathLib.Factorial(res).ToString();
                else
                    textBox1.Text = "Neplatny vstup";
            }

            else
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                    textBox1.Text = "Neplatny vstup";
                else
                {
                    LastOperation(var1, var2);
                    if (Int32.TryParse(result.ToString(), out res))
                    {
                        textBox1.Text = MathLib.Factorial(res).ToString();
                        var1 = Double.Parse(textBox1.Text);
                    }
                    else
                        textBox1.Text = "Neplatny vstup";
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
            var2 = 0;
            result = 0;
            textBox1.Text = "0";
            
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            var1 = var2 = 0;
            result = 0;
            textBox1.Text = "0";
            op = false;
            lastOp = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (lastOp != "")
            {
                if (!Double.TryParse(textBox1.Text, out var2))
                    textBox1.Text = "Neplatny vstup";
                else
                {
                    LastOperation(var1, var2);
                    textBox1.Text = result.ToString();
                    var1 = result;
                    lastOp = "";
                }
            }
            op = true;
        }
    }
}
