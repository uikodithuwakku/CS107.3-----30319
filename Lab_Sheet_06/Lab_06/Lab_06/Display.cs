using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06
{
    public partial class Display : System.Windows.Forms.Form
    {
        public Display()
        {
            InitializeComponent();
        }

        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\NSBM\Y1 - S3\C# Lab\Lab_06\Lab_06\Database1.mdf"";Integrated Security=True");

        private void butDisplay_Click(object sender, EventArgs e)
        {
            String query = "SELECT e.Name, e.DOB, c.Address,c.ContactNo,c.Email, e.UserName, e.Password  FROM Employee e INNER JOIN Contact c  ON e.UserName = c.UserName";

            //SqlAdapter --> for retrieve data from a database and populate a dataset by creating a connection with a database
            SqlDataAdapter adapter = new SqlDataAdapter(query, con1);

            //DataSet --> hold multiple data tables retrieved from a database temporary
            DataSet set = new DataSet();

            adapter.Fill(set, "Employee");//Create a dataset called Employee using retrieved data

            //assign the values to the gridview using that created tempory dataset
            dataGridView1.DataSource = set.Tables["Employee"];
        }
    }
}
