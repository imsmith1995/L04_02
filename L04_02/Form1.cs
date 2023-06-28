using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L04_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ChangeColor(Color newColor)
        {
            btnRed.BackColor = newColor;
            btnBlue.BackColor = newColor;
            btnGreen.BackColor = newColor;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Red);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Blue);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ChangeColor(Color.Green);
        }
    }
}

