using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_06
{ 
    public partial class Employee : System.Windows.Forms.Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Laptop Outlet\OneDrive\Y1 - S3\C# Lab\Lab_06\Lab_06\Database1.mdf"";Integrated Security=True");
        public Employee()
        {
            InitializeComponent();
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            String Dob = dateTimePicker1.Text;
            String Address = txtAddress.Text;
            int ConNo = int.Parse(txtNo.Text);
            String Email = txtEmail.Text;
            String Uname = txtUname.Text;
            String pwd = txtPwd.Text;

            String query = $"INSERT INTO Employee (Name,DOB,UserName,Password) VALUES ('{Name}','{Dob}','{Uname}','{pwd}')" ;
            SqlCommand cmd = new SqlCommand(query, con1);

            String query2 = $"INSERT INTO Contact (UserName,ContactNo,Email,Address) VALUES ('{Uname}','{ConNo}','{Email}','{Address}')";
            SqlCommand cmd2 = new SqlCommand(query2, con1);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                con1.Close();

                con1.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Registration Sucessfully....");
                con1.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error..." + ex.Message);
            }
            Reset();

        }

        private void butReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            txtName.Text = "";
            dateTimePicker1.Text = "";
            txtAddress.Text = "";
            txtNo.Text = "";
            txtEmail.Text = "";
            txtUname.Text = "";
            txtPwd.Text = "";
        }
    }
}
