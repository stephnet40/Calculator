using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Calculator
    {
        public double DoOperation(double num1, double num2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "add":
                    result = Addition(num1, num2);
                    break;
                case "subtract":
                    result = Subtraction(num1, num2);
                    break;
                case "multiply":
                    result = Multiplication(num1, num2);
                    break;
                case "divide":
                    result = Divide(num1, num2);
                    break;
            }

            if (result.ToString().Length > 20)
            {
                numberInput.Text = "ERR";
            }
            else 
            {
                numberInput.Text = result.ToString(); 
            }

            return result;
        }

        public double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        public double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        public bool CheckNoDivisionByZero(double num, string operation)
        {
            if (operation == "divide" && num == 0) 
            {
                divideByZeroErr.Text = "Can't Divide By 0";
                return false;
            }
            return true;
        }
    }
}
