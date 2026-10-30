using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form10 : Form
    {
        double number1 = 0;
        string operation = "";
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = "+";
            textBox1.Text = textBox1.Text + "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = "-";
            textBox1.Text = textBox1.Text + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = "*";
            textBox1.Text = textBox1.Text + "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation = "/";
            textBox1.Text = textBox1.Text + "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            int operationPosition = expression.IndexOf(operation);

            if (operationPosition == -1)
            {
                MessageBox.Show("Введите выражение!");
                return;
            }

            string firstNumber = expression.Substring(0, operationPosition);
            string secondNumber = expression.Substring(operationPosition + operation.Length);

            double number1 = Convert.ToDouble(firstNumber);
            double number2 = Convert.ToDouble(secondNumber);
            double result = 0;

            if (operation == "+")
            {
                result = number1 + number2;
            }
            else if (operation == "-")
            {
                result = number1 - number2;
            }
            else if (operation == "*")
            {
                result = number1 * number2;
            }
            else if (operation == "/")
            {
                if (number2 == 0)
                {
                    MessageBox.Show("На ноль делить нельзя!");
                    return;
                }

                result = number1 / number2;
            }
            else
            {
                MessageBox.Show("Сначала выберите действие!");
                return;
            }

            textBox1.Text = expression + " = " + result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            number1 = 0;
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
