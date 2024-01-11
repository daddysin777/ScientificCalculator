using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ÷ ";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += " x ";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            string[] syn = textBox1.Text.Split(' ');

            Double swp = 0;
            
            for(int i = 1; i < syn.Length; i+=2)
            {
                if(syn[i].Equals("+"))
                {
                    swp = Convert.ToDouble(syn[i + 1]);

                    syn[i + 1] = Convert.ToString(add(Convert.ToDouble(syn[i - 1]), swp));
                }

                if (syn[i].Equals("-"))
                {
                    swp = Convert.ToDouble(syn[i + 1]);

                    syn[i + 1] = Convert.ToString(subtract(Convert.ToDouble(syn[i - 1]), swp));
                }

                if (syn[i].Equals("x"))
                {
                    swp = Convert.ToDouble(syn[i + 1]);

                    syn[i + 1] = Convert.ToString(multiply(Convert.ToDouble(syn[i - 1]), swp));
                }

                if (syn[i].Equals("÷"))
                {
                    swp = Convert.ToDouble(syn[i + 1]);

                    syn[i + 1] = Convert.ToString(divide(Convert.ToDouble(syn[i - 1]), swp));
                }
            }

            textBox1.Text = syn[syn.Length - 1];
        }

        double add(double a, double b)
        {
            return a + b;
        }

        double subtract(double a, double b)
        {
            return a - b;
        }

        double multiply(double a, double b)
        {
            return a * b;
        }

        double divide(double a, double b)
        {
            return a / b;
        }
    }
}
