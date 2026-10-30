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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox3.Text);
            double result = 0;
            string operation = textBox2.Text.Trim();

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
                MessageBox.Show("Введите действие: +, -, * или /");
                return;
            }

            textBox4.Text = result.ToString();
            MessageBox.Show("Кнопка нажата!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
