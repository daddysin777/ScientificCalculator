using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculator1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            quadEqSolver1.BringToFront();
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculator1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculator1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            simEqSolver1.BringToFront();
        }
    }
}
