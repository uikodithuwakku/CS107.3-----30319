namespace Calculator
{
    partial class Q_01
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
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butSub = new System.Windows.Forms.Button();
            this.butMultiplication = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.Location = new System.Drawing.Point(98, 81);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(114, 29);
            this.lblValue1.TabIndex = 0;
            this.lblValue1.Text = "Value 01";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.Location = new System.Drawing.Point(98, 149);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(114, 29);
            this.lblValue2.TabIndex = 1;
            this.lblValue2.Text = "Value 02";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(98, 215);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(90, 29);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(306, 85);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(140, 26);
            this.txtValue1.TabIndex = 3;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(306, 149);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(140, 26);
            this.txtValue2.TabIndex = 4;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(314, 215);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 29);
            this.lblOut.TabIndex = 5;
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(60, 302);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(79, 54);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butSub
            // 
            this.butSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSub.Location = new System.Drawing.Point(194, 302);
            this.butSub.Name = "butSub";
            this.butSub.Size = new System.Drawing.Size(75, 54);
            this.butSub.TabIndex = 7;
            this.butSub.Text = "-";
            this.butSub.UseVisualStyleBackColor = true;
            this.butSub.Click += new System.EventHandler(this.butSub_Click);
            // 
            // butMultiplication
            // 
            this.butMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMultiplication.Location = new System.Drawing.Point(347, 302);
            this.butMultiplication.Name = "butMultiplication";
            this.butMultiplication.Size = new System.Drawing.Size(81, 54);
            this.butMultiplication.TabIndex = 8;
            this.butMultiplication.Text = "*";
            this.butMultiplication.UseVisualStyleBackColor = true;
            this.butMultiplication.Click += new System.EventHandler(this.butMultiplication_Click);
            // 
            // butDiv
            // 
            this.butDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiv.Location = new System.Drawing.Point(510, 302);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(78, 54);
            this.butDiv.TabIndex = 9;
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.butDiv_Click);
            // 
            // Q_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butMultiplication);
            this.Controls.Add(this.butSub);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Name = "Q_01";
            this.Text = "Q_01 & 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butSub;
        private System.Windows.Forms.Button butMultiplication;
        private System.Windows.Forms.Button butDiv;
    }
}

