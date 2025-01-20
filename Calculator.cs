using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void numberInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length < 8)
                numberInput.Text += "9";
        }
    }
}
