namespace Calculator
{
    partial class Q_03
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.butAddition = new System.Windows.Forms.Button();
            this.butSubstraction = new System.Windows.Forms.Button();
            this.butMul = new System.Windows.Forms.Button();
            this.butDivision = new System.Windows.Forms.Button();
            this.butOutput = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(220, 83);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(324, 35);
            this.txtInput.TabIndex = 0;
            // 
            // butAddition
            // 
            this.butAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddition.Location = new System.Drawing.Point(79, 227);
            this.butAddition.Name = "butAddition";
            this.butAddition.Size = new System.Drawing.Size(71, 40);
            this.butAddition.TabIndex = 1;
            this.butAddition.Text = "+";
            this.butAddition.UseVisualStyleBackColor = true;
            this.butAddition.Click += new System.EventHandler(this.butAddition_Click);
            // 
            // butSubstraction
            // 
            this.butSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubstraction.Location = new System.Drawing.Point(206, 227);
            this.butSubstraction.Name = "butSubstraction";
            this.butSubstraction.Size = new System.Drawing.Size(75, 40);
            this.butSubstraction.TabIndex = 2;
            this.butSubstraction.Text = "-";
            this.butSubstraction.UseVisualStyleBackColor = true;
            this.butSubstraction.Click += new System.EventHandler(this.butSubstraction_Click);
            // 
            // butMul
            // 
            this.butMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMul.Location = new System.Drawing.Point(344, 227);
            this.butMul.Name = "butMul";
            this.butMul.Size = new System.Drawing.Size(81, 40);
            this.butMul.TabIndex = 3;
            this.butMul.Text = "*";
            this.butMul.UseVisualStyleBackColor = true;
            this.butMul.Click += new System.EventHandler(this.butMul_Click);
            // 
            // butDivision
            // 
            this.butDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDivision.Location = new System.Drawing.Point(483, 227);
            this.butDivision.Name = "butDivision";
            this.butDivision.Size = new System.Drawing.Size(75, 40);
            this.butDivision.TabIndex = 4;
            this.butDivision.Text = "/";
            this.butDivision.UseVisualStyleBackColor = true;
            this.butDivision.Click += new System.EventHandler(this.butDivision_Click);
            // 
            // butOutput
            // 
            this.butOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOutput.Location = new System.Drawing.Point(620, 227);
            this.butOutput.Name = "butOutput";
            this.butOutput.Size = new System.Drawing.Size(77, 40);
            this.butOutput.TabIndex = 5;
            this.butOutput.Text = "=";
            this.butOutput.UseVisualStyleBackColor = true;
            this.butOutput.Click += new System.EventHandler(this.butOutput_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(143, 343);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(135, 44);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(306, 343);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 44);
            this.lblOut.TabIndex = 7;
            this.lblOut.Click += new System.EventHandler(this.label2_Click);
            // 
            // Q_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.butOutput);
            this.Controls.Add(this.butDivision);
            this.Controls.Add(this.butMul);
            this.Controls.Add(this.butSubstraction);
            this.Controls.Add(this.butAddition);
            this.Controls.Add(this.txtInput);
            this.Name = "Q_03";
            this.Text = "Q_03  calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button butAddition;
        private System.Windows.Forms.Button butSubstraction;
        private System.Windows.Forms.Button butMul;
        private System.Windows.Forms.Button butDivision;
        private System.Windows.Forms.Button butOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblOut;
    }
}