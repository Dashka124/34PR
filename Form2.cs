using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        Random random = new Random(); //рандомайзер
        int secretNumber; //загаданное число
        int attempts = 0; //попытки
        public Form2()
        {
            InitializeComponent();

            secretNumber = random.Next(1, 101);
            label2.Text = "Попробуй угадать!";
            label4.Text = "0";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int guess))
            {
                MessageBox.Show("Введите целое число!");
                return;
            }

            if (guess < 1 || guess > 100)
            {
                MessageBox.Show("Введите число от 1 до 100!");
                return;
            }

            attempts++;
            label4.Text = attempts.ToString();

            if (guess < secretNumber)
            {
                label2.Text = "Загаданное число больше";
            }
            else if (guess > secretNumber)
            {
                label2.Text = "Загаданное число меньше";
            }
            else
            {
                label5.Text = "ВЫ УГАДАЛИ!";
                label2.Text = "Правильно!";
            }
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secretNumber = random.Next(1, 101);
            attempts = 0;

            textBox1.Clear();
            label2.Text = "Попробуй угадать!";
            label4.Text = "0";

            button1.Enabled = true;
        }
    }
}
