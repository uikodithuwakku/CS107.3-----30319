using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class EditInfo : System.Windows.Forms.Form
    {
        public EditInfo()
        {
            InitializeComponent();
        }

        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Laptop Outlet\OneDrive\Y1 - S3\C# Lab\Lab_06\Lab_06\Database1.mdf"";Integrated Security=True");

        private void butSearch_Click(object sender, EventArgs e)
        {
            String Uname = txtUname.Text;
            String query3 = $"SELECT e.Name, e.DOB, c.Address,c.ContactNo,c.Email, e.UserName, e.Password  FROM Employee e INNER JOIN Contact c  ON e.UserName = c.UserName WHERE e.UserName='{Uname}'";
  
            SqlCommand cmd = new SqlCommand(query3, con1);

            try
            {
                con1.Open();
                SqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    txtName.Text = data["Name"].ToString();
                    dateTimePicker1.Text = data["DOB"].ToString();
                    txtAddress.Text = data["Address"].ToString();
                    txtNo.Text = data["ContactNo"].ToString();
                    txtEmail.Text = data["Email"].ToString();
                    txtPwd.Text = data["Password"].ToString();
                    con1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            Display form4 = new Display();
            form4.Show();
            this.Hide();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            string Uname = txtUname.Text;
            string Name = txtUname.Text;
            string Dob = dateTimePicker1.Text;
            string Address = txtAddress.Text;
            int ContactNo = int.Parse(txtNo.Text);
            string Email = txtEmail.Text;
            string Password = txtPwd.Text;
            
            string Query = "";

            if (Name  == "" || Dob == "" || Password=="")
            {
                Query = $"UPDATE Employee SET Name='{Name}', DOB='{Dob}',Prassword='{Password}' WHERE UserName='{Uname}'";
            }
            else
            {
                Query = $"UPDATE Contact SET ContactNo={ContactNo}, Email='{Email}',Address='{Address}' WHERE UserName='{Uname}'";
            }

            SqlCommand cmd1 = new SqlCommand(Query, con1);

            try
            {
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Data Updated sucessfully....", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
