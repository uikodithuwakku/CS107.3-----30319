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
        bool but_click;

        private void button_click(object sender, EventArgs e)
        {
            if((txtInput.Text == "0") || (operation_process))
            {
                txtInput.Clear();   
            }
            
            Button b = (Button)sender;

            if(b.Text == ".")
            {
                if(!txtInput.Text.Contains("."))
                {
                    txtInput.Text = txtInput.Text + b.Text;
                }
            }
            else
            {
                txtInput.Text = txtInput.Text + b.Text;
            }
            operation_process = false;
        }

        private void operation_click(object sender, EventArgs e)
        {
            try
            {
                if(value != 0)
                {
                    butOutput.PerformClick();
                    Button b = (Button)sender;
                    operation = b.Text;
                    value = Double.Parse(txtInput.Text);
                    //lblOutput.Text = value +  operation;
                    operation_process = true;
                }
                else
                {
                    Button b = (Button)sender;
                    operation = b.Text;
                    value = Double.Parse(txtInput.Text);
                    //lblOutput.Text = value +  operation;
                    operation_process = true;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter valid number", "Error");
                //lblOutput.Text = "";
            }
            
        }

        private void butCE_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            value = 0;
        }

        private void butC_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            //lblOutput.Text = "";
        }

        private void butOutput_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == ".") || (but_click))
            {
                txtInput.Clear();
            }
            

            try
            {
                //lblOutput.Text = "";
                switch (operation)
                {
                    case "+": txtInput.Text = (value + Double.Parse(txtInput.Text)).ToString(); break;
                    case "-": txtInput.Text = (value - Double.Parse(txtInput.Text)).ToString(); break;
                    case "*": txtInput.Text = (value * Double.Parse(txtInput.Text)).ToString(); break;
                    case "/": 
                        if(double.Parse(txtInput.Text) == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        txtInput.Text = (value / Double.Parse(txtInput.Text)).ToString(); break;
                    default: break;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter valid number", "Error"); //for second number
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero", "Error");
            }  
        }
    }
}
