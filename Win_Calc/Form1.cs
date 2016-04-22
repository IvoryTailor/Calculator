using System;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Calculator : Form
    {
        string TrimFirst(string input, char opperator)
        {
            string[] inputArr = input.Split(new []{ opperator }, StringSplitOptions.RemoveEmptyEntries);

            return inputArr[1];
        } // Substarcts The First Two chars in the String Input. "1+2" => gets only 2

        private long value = 0;
        private char operation = '?';
        private bool operationPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonClickDot(object sender, EventArgs e)
        {
            result.Text = result.Text + ".";
        }

        private void ButtonClickZero(object sender, EventArgs e)
        {
            result.Text = result.Text + "0";
        }

        private void ButtonClickDel(object sender, EventArgs e)
        {
            result.Clear();
        }  //Delete

        private void ButtonClickOne(object sender, EventArgs e)
        {
            result.Text = result.Text + "1";
        }

        private void ButtonClickTwo(object sender, EventArgs e)
        {
            result.Text = result.Text + "2";
        }

        private void ButtonClickThree(object sender, EventArgs e)
        {
            result.Text = result.Text + "3";
        }

        private void ButtonClickFour(object sender, EventArgs e)
        {
            result.Text = result.Text + "4";
        }

        private void ButtonClickFive(object sender, EventArgs e)
        {
            result.Text = result.Text + "5";
        }

        private void ButtonClickSix(object sender, EventArgs e)
        {
            result.Text = result.Text + "6";
        }

        private void ButtonClickSeven(object sender, EventArgs e)
        {
            result.Text = result.Text + "7";
        }

        private void ButtonClickEight(object sender, EventArgs e)
        {
            result.Text = result.Text + "8";
        }

        private void ButtonClickNine(object sender, EventArgs e)
        {
            result.Text = result.Text + "9";
        }

        private void ButtonClickEqual(object sender, EventArgs e)
        {
            switch (operation)
            {
                case '*':
                    result.Text = (value * Convert.ToInt64(TrimFirst(result.Text, '*'))).ToString();
                    break;
                case '/':
                    result.Text = (value / Convert.ToInt64(TrimFirst(result.Text, '/'))).ToString();
                    break;
                case '+':
                    result.Text = (value + Convert.ToInt64(TrimFirst(result.Text, '+'))).ToString();
                    break;
                case '-':
                    result.Text = (value + Convert.ToInt64(TrimFirst(result.Text, '-'))).ToString();
                    break;
            }
        }

        private void ButtonClickDecimal(object sender, EventArgs e)
        {

        } //Decimal

        private void ButtonClickBinary(object sender, EventArgs e)
        {

        } //Binary

        private void ButtonClickHex(object sender, EventArgs e)
        {

        } //Hex

        private void ButtonClickInv(object sender, EventArgs e)
        {
            result.Text = result.Text + "~";
        }

        private void ButtonClickSLeft(object sender, EventArgs e)
        {
            result.Text = result.Text + "<<";
        }

        private void ButtonClickSRight(object sender, EventArgs e)
        {
            result.Text = result.Text + ">>";
        }

        private void ButtonClickMask(object sender, EventArgs e)
        {

        }  //Mask

        private void ButtonClickLeft(object sender, EventArgs e)
        {
            result.Text = result.Text + "(";
        }

        private void ButtonClickRight(object sender, EventArgs e)
        {
            result.Text = result.Text + ")";
        }

        private void ButtonClickMultiply(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                result.Clear();
                operationPressed = false;
            }

            value = Convert.ToInt64(result.Text);
            operation = '*';
            result.Text += operation;
        }

        private void ButtonClickDivide(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                result.Clear();
                operationPressed = false;
            }

            value = Convert.ToInt64(result.Text);
            operation = '/';
            result.Text += operation;
        }

        private void ButtonClickAdd(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                result.Clear();
                operationPressed = false;
            }

            value = Convert.ToInt64(result.Text);
            operation = '+';
            result.Text += operation;
            operationPressed = true;
        }

        private void ButtonClickSubstract(object sender, EventArgs e)
        {
            if (operationPressed)
            {
                result.Clear();
                operationPressed = false;
            }

            value = Convert.ToInt64(result.Text);
            operation = '-';
            result.Text += operation;
        }

        private void ButtonClickAnd(object sender, EventArgs e)
        {
            operation = '&';
            result.Text += operation;
        }

        private void ButtonClickXor(object sender, EventArgs e)
        {
            operation = '^';
            result.Text += operation;
        }

        private void ButtonClickOr(object sender, EventArgs e)
        {
            operation = '|';
            result.Text += operation;
        }

        private void ButtonClickClose(object sender, EventArgs e)
        {

        } //Close
    }
}
