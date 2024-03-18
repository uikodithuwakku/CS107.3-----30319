using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab_05_B_
{
    public partial class Form1 : Form
    {
        private void butReset_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            dateTimePicker1.Text = "";
            txtEmail.Text = "";
            txtUname.Text = "";
            txtPwd.Text = "";
            txtConfirmPwd.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void butSignup_Click(object sender, EventArgs e)
        {
             if(string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUname.Text) || string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtConfirmPwd.Text))
             {
                 MessageBox.Show("Input fields are empty....", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
             }

             else if(txtPwd.Text != txtConfirmPwd.Text)
             {
                 MessageBox.Show("Psswords are doesn't match....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

             else
             {
                Form2 form2 = new Form2();
                form2.passingvalue = txtFname.Text + " " + txtLname.Text;
                form2.passingvalue1 = txtUname.Text; 
                form2.passingvalue2 = txtEmail.Text;
                form2.Show();
                this.Hide();
             }

            
        }
    }
}
