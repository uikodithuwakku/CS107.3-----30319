using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void butContact_Click(object sender, EventArgs e)
        {
            EditInfo edit = new EditInfo();
            edit.Show();
            this.Hide();
        }

        private void butDisplayEmployee_Click(object sender, EventArgs e)
        {
            Display displayInfo = new Display();
            displayInfo.Show();
            this.Hide();
        }
    }
}
