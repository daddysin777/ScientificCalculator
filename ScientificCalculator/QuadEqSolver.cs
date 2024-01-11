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
    public partial class QuadEqSolver : UserControl
    {
        Double a, b, c;
        public QuadEqSolver()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            c = 0;
        }

        private void QuadEqSolver_Load(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            DiscDisp.Text = "";
            RootDisp.Text = "";
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Equalto_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            double D = b * b - 4 * a * c;

            DiscDisp.Text = "Discriminant = " + Convert.ToString(D);

            RootDisp.Text = "Roots = " + Convert.ToString((-b + Math.Sqrt(D)) / (2 * a)) + " or " + Convert.ToString((-b - Math.Sqrt(D)) / (2 * a));
        }
    }
}
