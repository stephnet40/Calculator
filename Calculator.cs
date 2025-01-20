using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        bool startNum2 = false;
        double num1;
        double num2;
        double prevNumEntered;
        string operation = "";
        string prevOperation = "";

        private void zero_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            } 

            if (numberInput.Text.Length < 20)
                numberInput.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (startNum2)
            {
                divideByZeroErr.Text = "";
                numberInput.Text = "";
                startNum2 = false;
            }

            if (numberInput.Text.Length < 20)
                numberInput.Text += "9";
        }

        private void add_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(numberInput.Text);

            if (operation == "")
            {
                num1 = double.Parse(numberInput.Text);
            } 
            else
            {
                num1 = DoOperation(num1, num2, operation);
            }

            operation = "add";
            startNum2 = true;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(numberInput.Text);

            if (operation == "")
            {
                num1 = double.Parse(numberInput.Text);
            }
            else
            {
                num1 = DoOperation(num1, num2, operation);
            }

            operation = "subtract";
            startNum2 = true;     
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(numberInput.Text);

            if (operation == "")
            {
                num1 = double.Parse(numberInput.Text);
            }
            else
            {
                num1 = DoOperation(num1, num2, operation);
            }

            operation = "multiply";
            startNum2 = true;           
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(numberInput.Text);

            if (operation == "")
            {
                num1 = double.Parse(numberInput.Text);
            }
            else if (CheckNoDivisionByZero(num2, operation))
            {
                num1 = DoOperation(num1, num2, operation);
            }

            operation = "divide";
            startNum2 = true;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(numberInput.Text);

            if (numberInput.Text != "")
            {
                if (operation == "" && CheckNoDivisionByZero(prevNumEntered, prevOperation))
                {
                    num1 = prevOperation != "" ? DoOperation(num2, prevNumEntered, prevOperation) : num2;
                } 
                else if (CheckNoDivisionByZero(num2, operation))
                {
                    prevNumEntered = double.Parse(numberInput.Text);
                    num1 = DoOperation(num1, num2, operation);
                    prevOperation = operation;
                    operation = "";
                }
                
                startNum2 = true;
            }          
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (num1 == double.Parse(numberInput.Text))
            {
                num1 = 0;
            }
            numberInput.Text = "";
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            prevNumEntered = 0;
            numberInput.Text = "";
            operation = "";
            prevOperation = "";
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (numberInput.Text == "" || startNum2)
            {
                numberInput.Text = "";
                numberInput.Text += "-";
                startNum2 = false;
            } 
            else
            {
                double input = double.Parse(numberInput.Text) * -1;
                numberInput.Text = input.ToString();        
            }
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            if (numberInput.Text == "" || startNum2)
            {
                numberInput.Text = "";
                numberInput.Text += "0.";
                startNum2 = false;
            }
            else
            {
                numberInput.Text += ".";
            }
        }
        private void numberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
