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
    public partial class SimEqSolver : UserControl
    {
        Double a1, b1, c1, a2, b2, c2;
        public SimEqSolver()
        {
            InitializeComponent();
            a1 = 0;
            a2 = 0;
            b1 = 0;
            b2 = 0;
            c1 = 0;
            c2 = 0;
        }

        private void Equalto_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(textBox1.Text);
            a2 = Convert.ToDouble(textBox6.Text);
            b1 = Convert.ToDouble(textBox2.Text);
            b2 = Convert.ToDouble(textBox5.Text);
            c1 = Convert.ToDouble(textBox3.Text);
            c2 = Convert.ToDouble(textBox4.Text);

            ans.Text = "X = " + Convert.ToString(FindX()) + " Y = " + Convert.ToString(FindY());
        }

        Double FindX()
        {
            double s1, s2;

            s1 = b2;
            s2 = b1; 

            a1 *= s1;
            b1 *= s1;
            c1 *= s1;

            a2 *= s2;
            b2 *= s2;
            c2 *= s2;

            double x = -(c1 - c2) / (a1 - a2);

            a1 /= s1;
            b1 /= s1;
            c1 /= s1;

            a2 /= s2;
            b2 /= s2;
            c2 /= s2;

            return x;
        }

        Double FindY()
        {
            double s1, s2;

            s1 = a2;
            s2 = a1;

            a1 *= s1;
            b1 *= s1;
            c1 *= s1;

            a2 *= s2;
            b2 *= s2;
            c2 *= s2;

            double y = -(c1 - c2) / (a1 - a2);

            a1 /= s1;
            b1 /= s1;
            c1 /= s1;

            a2 /= s2;
            b2 /= s2;
            c2 /= s2;

            return y;
        }
    }
}
