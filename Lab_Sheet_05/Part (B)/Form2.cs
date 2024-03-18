using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05_B_
{
    public partial class Form2 : Form
    {
        public string name, Uname, Email;

        public string passingvalue
        {
            get { return name; }
            set { name = value; }
        }

        public string passingvalue1
        {
            get { return Uname; }
            set { Uname = value; }
        }

        public string passingvalue2
        {
            get { return Email; }
            set { Email = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = "" + name;
            lblUname.Text = "" +Uname;
            lblEmail.Text = "" + Email;
        }
    }
}
