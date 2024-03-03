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
    public partial class Q_03 : Form
    {
        public Q_03()
        {
            InitializeComponent();
        }

        public int no1;
        int flag;
        int result;

        private void butAddition_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtInput.Text , out no1) )
            {
                no1 = int.Parse(txtInput.Text);
                txtInput.Text = "";
                flag = 1;
            }
            else
            {
                MessageBox.Show("Invalid Input.....");
            }
        }

        private void butSubstraction_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out no1))
            {
                no1 = int.Parse(txtInput.Text);
                txtInput.Text = "";
                flag = 2;
            }
            else
            {
                MessageBox.Show("Invalid Input.....");
            }
        }

        private void butMul_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out no1))
            {
                no1 = int.Parse(txtInput.Text);
                txtInput.Text = "";
                flag = 3;
            }
            else
            {
                MessageBox.Show("Invalid Input.....");
            }
        }

        private void butDivision_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out no1))
            {
                no1 = int.Parse(txtInput.Text);
                txtInput.Text = "";
                flag = 4;
            }
            else
            {
                MessageBox.Show("Invalid Input.....");
            }
        }

        private void butOutput_Click(object sender, EventArgs e)
        {
            int no2 = int.Parse(txtInput.Text);

            if(flag == 1)
            {
                result = no1 + no2;
            }
            else if (flag == 2)
            {
                result = no1 - no2;
            }
            else if (flag == 3)
            {
                result = no1 * no2;
            }
            else
            {
                result = no1 / no2;
            }
            lblOut.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
