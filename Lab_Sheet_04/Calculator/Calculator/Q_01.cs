using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
   public partial class Q_01 : Form
    {
        public Q_01()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        private void butAdd_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtValue1.Text);
            num2 = int.Parse(txtValue2.Text);
            lblOut.Text = (num1 + num2).ToString();
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtValue1.Text);
            num2 = int.Parse(txtValue2.Text);
            lblOut.Text = (num1 - num2).ToString();
        }

        private void butMultiplication_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtValue1.Text);
            num2 = int.Parse(txtValue2.Text);
            lblOut.Text = (num1 * num2).ToString();
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtValue1.Text);
            num2 = int.Parse(txtValue2.Text);
            lblOut.Text = (num1 / num2).ToString();
        }
    }
}
