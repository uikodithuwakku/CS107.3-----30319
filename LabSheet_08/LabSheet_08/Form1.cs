using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabSheet_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtGrossSal.Text = "";
            txtTaxP.Text = "";
            lblNetSal.Text = "";
            lblTaxSal.Text = "";
        }

        private void butCal_Click(object sender, EventArgs e)
        {
            CalcTax();
            CalcNetSal();
            MessageBox.Show("Net Salary : " + lblNetSal.Text , "Net Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*double sal = Convert.ToDouble(txtGrossSal.Text);
            double taxper = Convert.ToDouble(txtTaxP.Text);
            double tax = CalcTax(sal,taxper);
            double netSal = CalcNetSal(sal,tax);
            lblTaxSal.Text = tax.Tostring();
            lblNetSal.Text = netSal.Tostring();
            */
        }

        private void CalcTax()
        {
            double sal = Convert.ToDouble(txtGrossSal.Text);
            double taxper = Convert.ToDouble(txtTaxP.Text);
            double tax = (sal * taxper) / 100;
            lblTaxSal.Text = Convert.ToDouble(tax).ToString();
        }

        private void CalcNetSal()
        {
            double sal = Convert.ToDouble(txtGrossSal.Text);
            double tax = Convert.ToDouble(lblTaxSal.Text);
            double netSal = sal - tax;
            lblNetSal.Text = Convert.ToDouble(netSal).ToString();
        }

        
        /*  private double CalcTax(double sal,double taxPer)
        {
            return (sal * taxper) / 100;
        }

          private void CalcNetSal(double sal, double tax)
        {
            return  netSal = sal - tax;
        }*/
        
    }
}
