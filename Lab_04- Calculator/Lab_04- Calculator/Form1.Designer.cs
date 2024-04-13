namespace Lab_04__Calculator
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.but7 = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butCE = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.butSub = new System.Windows.Forms.Button();
            this.butC = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.butOutput = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.butDec = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(30, 66);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(424, 58);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // but7
            // 
            this.but7.Location = new System.Drawing.Point(30, 182);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(80, 76);
            this.but7.TabIndex = 1;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.button_click);
            // 
            // butMultiply
            // 
            this.butMultiply.Location = new System.Drawing.Point(288, 346);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Size = new System.Drawing.Size(80, 76);
            this.butMultiply.TabIndex = 2;
            this.butMultiply.Text = "*";
            this.butMultiply.UseVisualStyleBackColor = true;
            this.butMultiply.Click += new System.EventHandler(this.operation_click);
            // 
            // but9
            // 
            this.but9.Location = new System.Drawing.Point(202, 182);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(80, 76);
            this.but9.TabIndex = 3;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.button_click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(288, 182);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(80, 76);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.operation_click);
            // 
            // butCE
            // 
            this.butCE.Location = new System.Drawing.Point(374, 182);
            this.butCE.Name = "butCE";
            this.butCE.Size = new System.Drawing.Size(80, 76);
            this.butCE.TabIndex = 5;
            this.butCE.Text = "CE";
            this.butCE.UseVisualStyleBackColor = true;
            this.butCE.Click += new System.EventHandler(this.butCE_Click);
            // 
            // but5
            // 
            this.but5.Location = new System.Drawing.Point(116, 264);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(80, 76);
            this.but5.TabIndex = 6;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.button_click);
            // 
            // but6
            // 
            this.but6.Location = new System.Drawing.Point(202, 264);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(80, 76);
            this.but6.TabIndex = 7;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.button_click);
            // 
            // but8
            // 
            this.but8.Location = new System.Drawing.Point(116, 182);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(80, 76);
            this.but8.TabIndex = 8;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.button_click);
            // 
            // butSub
            // 
            this.butSub.Location = new System.Drawing.Point(288, 264);
            this.butSub.Name = "butSub";
            this.butSub.Size = new System.Drawing.Size(80, 76);
            this.butSub.TabIndex = 9;
            this.butSub.Text = "-";
            this.butSub.UseVisualStyleBackColor = true;
            this.butSub.Click += new System.EventHandler(this.operation_click);
            // 
            // butC
            // 
            this.butC.Location = new System.Drawing.Point(374, 264);
            this.butC.Name = "butC";
            this.butC.Size = new System.Drawing.Size(80, 76);
            this.butC.TabIndex = 10;
            this.butC.Text = "C";
            this.butC.UseVisualStyleBackColor = true;
            this.butC.Click += new System.EventHandler(this.butC_Click);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(30, 346);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(80, 76);
            this.but1.TabIndex = 11;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.button_click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(116, 346);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(80, 76);
            this.but2.TabIndex = 12;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.button_click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(202, 346);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(80, 76);
            this.but3.TabIndex = 13;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.button_click);
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(30, 264);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(80, 76);
            this.but4.TabIndex = 14;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.button_click);
            // 
            // butOutput
            // 
            this.butOutput.Location = new System.Drawing.Point(374, 346);
            this.butOutput.Name = "butOutput";
            this.butOutput.Size = new System.Drawing.Size(80, 158);
            this.butOutput.TabIndex = 15;
            this.butOutput.Text = "=";
            this.butOutput.UseVisualStyleBackColor = true;
            this.butOutput.Click += new System.EventHandler(this.butOutput_Click);
            // 
            // but0
            // 
            this.but0.Location = new System.Drawing.Point(30, 428);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(166, 76);
            this.but0.TabIndex = 16;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.button_click);
            // 
            // butDec
            // 
            this.butDec.Location = new System.Drawing.Point(202, 428);
            this.butDec.Name = "butDec";
            this.butDec.Size = new System.Drawing.Size(80, 76);
            this.butDec.TabIndex = 17;
            this.butDec.Text = ".";
            this.butDec.UseVisualStyleBackColor = true;
            this.butDec.Click += new System.EventHandler(this.button_click);
            // 
            // butDiv
            // 
            this.butDiv.Location = new System.Drawing.Point(288, 428);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(80, 76);
            this.butDiv.TabIndex = 18;
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.operation_click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(30, 141);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 30);
            this.lblOutput.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 531);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butDec);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.butOutput);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.butC);
            this.Controls.Add(this.butSub);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.butCE);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.butMultiply);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCE;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button butSub;
        private System.Windows.Forms.Button butC;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button butOutput;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button butDec;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Label lblOutput;
    }
}

