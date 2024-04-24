namespace LabSheet_08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.lblGsalary = new System.Windows.Forms.Label();
            this.txtGrossSal = new System.Windows.Forms.TextBox();
            this.txtTaxP = new System.Windows.Forms.TextBox();
            this.lblTaxPercent = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.butCal = new System.Windows.Forms.Button();
            this.lblTaxSal = new System.Windows.Forms.Label();
            this.lblNetSal = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(48, 66);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(273, 29);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Please Enter the details ";
            // 
            // lblGsalary
            // 
            this.lblGsalary.AutoSize = true;
            this.lblGsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGsalary.Location = new System.Drawing.Point(48, 159);
            this.lblGsalary.Name = "lblGsalary";
            this.lblGsalary.Size = new System.Drawing.Size(150, 29);
            this.lblGsalary.TabIndex = 1;
            this.lblGsalary.Text = "Gross Salary";
            // 
            // txtGrossSal
            // 
            this.txtGrossSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossSal.Location = new System.Drawing.Point(329, 153);
            this.txtGrossSal.Name = "txtGrossSal";
            this.txtGrossSal.Size = new System.Drawing.Size(271, 35);
            this.txtGrossSal.TabIndex = 2;
            // 
            // txtTaxP
            // 
            this.txtTaxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxP.Location = new System.Drawing.Point(329, 217);
            this.txtTaxP.Name = "txtTaxP";
            this.txtTaxP.Size = new System.Drawing.Size(271, 35);
            this.txtTaxP.TabIndex = 4;
            // 
            // lblTaxPercent
            // 
            this.lblTaxPercent.AutoSize = true;
            this.lblTaxPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPercent.Location = new System.Drawing.Point(48, 223);
            this.lblTaxPercent.Name = "lblTaxPercent";
            this.lblTaxPercent.Size = new System.Drawing.Size(183, 29);
            this.lblTaxPercent.TabIndex = 3;
            this.lblTaxPercent.Text = "Tax Percentage";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(48, 291);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(140, 29);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax Amount";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(48, 357);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(124, 29);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Net Salary";
            // 
            // butCal
            // 
            this.butCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCal.Location = new System.Drawing.Point(102, 487);
            this.butCal.Name = "butCal";
            this.butCal.Size = new System.Drawing.Size(197, 64);
            this.butCal.TabIndex = 9;
            this.butCal.Text = "Calculate";
            this.butCal.UseVisualStyleBackColor = true;
            this.butCal.Click += new System.EventHandler(this.butCal_Click);
            // 
            // lblTaxSal
            // 
            this.lblTaxSal.AutoSize = true;
            this.lblTaxSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxSal.Location = new System.Drawing.Point(324, 291);
            this.lblTaxSal.Name = "lblTaxSal";
            this.lblTaxSal.Size = new System.Drawing.Size(0, 29);
            this.lblTaxSal.TabIndex = 10;
            // 
            // lblNetSal
            // 
            this.lblNetSal.AutoSize = true;
            this.lblNetSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetSal.Location = new System.Drawing.Point(324, 357);
            this.lblNetSal.Name = "lblNetSal";
            this.lblNetSal.Size = new System.Drawing.Size(0, 29);
            this.lblNetSal.TabIndex = 11;
            // 
            // butClear
            // 
            this.butClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.Location = new System.Drawing.Point(387, 487);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(197, 64);
            this.butClear.TabIndex = 12;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 630);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.lblNetSal);
            this.Controls.Add(this.lblTaxSal);
            this.Controls.Add(this.butCal);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTaxP);
            this.Controls.Add(this.lblTaxPercent);
            this.Controls.Add(this.txtGrossSal);
            this.Controls.Add(this.lblGsalary);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblGsalary;
        private System.Windows.Forms.TextBox txtGrossSal;
        private System.Windows.Forms.TextBox txtTaxP;
        private System.Windows.Forms.Label lblTaxPercent;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button butCal;
        private System.Windows.Forms.Label lblTaxSal;
        private System.Windows.Forms.Label lblNetSal;
        private System.Windows.Forms.Button butClear;
    }
}

