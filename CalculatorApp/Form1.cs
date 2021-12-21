using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string input = "";
        string first = "";
        string second = ""; 
        string previousValue = "";
        char function;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "0";
            calculatorDisplay.Text += input;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "1";
            calculatorDisplay.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "2";
            calculatorDisplay.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "3";
            calculatorDisplay.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "4";
            calculatorDisplay.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "5";
            calculatorDisplay.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "6";
            calculatorDisplay.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "7";
            calculatorDisplay.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "8";
            calculatorDisplay.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = previousValue;
            input += "9";
            calculatorDisplay.Text += input;
        }

        

        private void divisionButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = input;
            input = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = input;
            input = "";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = input;
            input = "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = input;
            input = "";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            second = input;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //Addition
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Subtract
            else if(function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Divide
            else if(function == '/')
            {
                if(secondNum == '0')
                {
                    calculatorDisplay.Text = "Error";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
            }
            //Multiply
            else if(function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            input = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }
    }
}
