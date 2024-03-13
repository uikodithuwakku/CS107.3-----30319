using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04__Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value;
        bool operation_process;
        string operation;

        private void button_click(object sender, EventArgs e)
        {
            if((txtInput.Text == "0") || (operation_process))
            {
                txtInput.Clear();   
            }
            operation_process = false;
            Button b = (Button)sender;
            txtInput.Text = txtInput.Text + b.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            operation = c.Text;
            value = Double.Parse(txtInput.Text);
            operation_process = true;
            lblOutput.Text = value + " " + operation;
        }

        private void butCE_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            value = 0;
        }

        private void butC_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
        }

        private void butOutput_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            switch(operation)
            {
                case "+": txtInput.Text = (value + Double.Parse(txtInput.Text)).ToString(); break;
                case "-": txtInput.Text = (value - Double.Parse(txtInput.Text)).ToString(); break;
                case "*": txtInput.Text = (value * Double.Parse(txtInput.Text)).ToString(); break;
                case "/": txtInput.Text = (value / Double.Parse(txtInput.Text)).ToString(); break;
                default: break;
            }
        }
    }
}
