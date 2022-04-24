using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        protected double FirstNumber, Result;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "1";
            }
            else 
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "9";
            }
            else 
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operation = "+";
            textBox1.Text = "0";  
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operation = "-";
            textBox1.Text = "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operation = "*";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(textBox1.Text);
            Operation = "/";
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Focus();
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Result * -1;
            textBox1.Text = Result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            Result = double.Parse(textBox1.Text);
            Result = Result / 100;
            textBox1.Text = Result.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Sqrt(Result);
            textBox1.Text = Result.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Pow(Result, 2);
            textBox1.Text= Result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Pow(Result, 3);
            textBox1.Text= Result.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {

            Result = double.Parse(textBox1.Text);
            Result = 1 / Result;
            textBox1.Text = Result.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Log10(Result);
            textBox1.Text = Result.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Sin(Result);
            textBox1.Text = Result.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Cos(Result);
            textBox1.Text = Result.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Tan(Result);
            textBox1.Text = Result.ToString();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Result = Math.PI;
            textBox1.Text=Result.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Result = double.Parse(textBox1.Text);
            Result = Math.Exp(Result);
            textBox1.Text = Result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    textBox1.Text = (FirstNumber + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (FirstNumber - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (FirstNumber * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (FirstNumber / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
    
    }
}
