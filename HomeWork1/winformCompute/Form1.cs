using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add1.Text = "hello world!";
        }

        private void add1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool judgeInput()
        {
            double number1, number2;

            if (!double.TryParse(textBox1.Text, out number1) || !double.TryParse(textBox2.Text, out number2))
            {
                result.Text = "Input erorr, please enter a number!";
                return false;
            }
            else if (functionBox.Text == "div" && textBox2.Text == "0")
            {
                result.Text = "Input erorr, the divident can't be a zero!";
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (judgeInput())
            {
                double num1 = Double.Parse(textBox1.Text);
                double num2 = Double.Parse(textBox2.Text);
                switch (functionBox.Text)
                {
                    case "add":
                        result.Text = $"{num1 + num2}";
                        break;
                    case "sub":
                        result.Text = $"{num1 - num2}";
                        break;
                    case "mul":
                        result.Text = $"{num1 * num2}";
                        break;
                    case "div":
                        result.Text = $"{num1 / num2}";
                        break;
                    default:
                        break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
