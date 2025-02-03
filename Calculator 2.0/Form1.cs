using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += ((Button)sender).Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            object result = dt.Compute(textBox1.Text, "");
            textBox1.Text = result.ToString();

            //for (int i = 0; i < textBox1.TextLength; i++)
            //{
            //    if (textBox1.Text[i] == '+')
            //    {
            //        string[] numbers = textBox1.Text.Split('+');
            //        double num1 = Convert.ToDouble(numbers[0]);
            //        double num2 = Convert.ToDouble(numbers[1]);
            //        double result = num1 + num2;
            //        textBox1.Text = result.ToString();
            //    }
            //    else if (textBox1.Text[i] == '-')
            //    {
            //        string[] numbers = textBox1.Text.Split('-');
            //        double num1 = Convert.ToDouble(numbers[0]);
            //        double num2 = Convert.ToDouble(numbers[1]);
            //        double result = num1 - num2;
            //        textBox1.Text = result.ToString();
            //    }
            //    else if (textBox1.Text[i] == '*')
            //    {
            //        string[] numbers = textBox1.Text.Split('*');
            //        double num1 = Convert.ToDouble(numbers[0]);
            //        double num2 = Convert.ToDouble(numbers[1]);
            //        double result = num1 * num2;
            //        textBox1.Text = result.ToString();
            //    }
            //    else if (textBox1.Text[i] == '/')
            //    {
            //        string[] numbers = textBox1.Text.Split('/');
            //        double num1 = Convert.ToDouble(numbers[0]);
            //        double num2 = Convert.ToDouble(numbers[1]);
            //        double result = num1 / num2;
            //        textBox1.Text = result.ToString();
            //    }
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
