namespace Lab_06
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
            this.butEmployee = new System.Windows.Forms.Button();
            this.butContact = new System.Windows.Forms.Button();
            this.butDisplayEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butEmployee
            // 
            this.butEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmployee.Location = new System.Drawing.Point(64, 148);
            this.butEmployee.Name = "butEmployee";
            this.butEmployee.Size = new System.Drawing.Size(163, 102);
            this.butEmployee.TabIndex = 0;
            this.butEmployee.Text = "Employee Details";
            this.butEmployee.UseVisualStyleBackColor = true;
            this.butEmployee.Click += new System.EventHandler(this.butEmployee_Click);
            // 
            // butContact
            // 
            this.butContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butContact.Location = new System.Drawing.Point(297, 148);
            this.butContact.Name = "butContact";
            this.butContact.Size = new System.Drawing.Size(168, 102);
            this.butContact.TabIndex = 1;
            this.butContact.Text = "Edit Details";
            this.butContact.UseVisualStyleBackColor = true;
            this.butContact.Click += new System.EventHandler(this.butContact_Click);
            // 
            // butDisplayEmployee
            // 
            this.butDisplayEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDisplayEmployee.Location = new System.Drawing.Point(530, 148);
            this.butDisplayEmployee.Name = "butDisplayEmployee";
            this.butDisplayEmployee.Size = new System.Drawing.Size(180, 102);
            this.butDisplayEmployee.TabIndex = 2;
            this.butDisplayEmployee.Text = "Display Employee Details";
            this.butDisplayEmployee.UseVisualStyleBackColor = true;
            this.butDisplayEmployee.Click += new System.EventHandler(this.butDisplayEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDisplayEmployee);
            this.Controls.Add(this.butContact);
            this.Controls.Add(this.butEmployee);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butEmployee;
        private System.Windows.Forms.Button butContact;
        private System.Windows.Forms.Button butDisplayEmployee;
    }
}

