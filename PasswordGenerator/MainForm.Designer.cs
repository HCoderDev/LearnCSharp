namespace PasswordGenerator
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.trackBarLength = new System.Windows.Forms.TrackBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUppercase);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.chkSymbols);
            this.groupBox1.Controls.Add(this.chkDigits);
            this.groupBox1.Controls.Add(this.chkLowercase);
            this.groupBox1.Controls.Add(this.trackBarLength);
            this.groupBox1.Location = new System.Drawing.Point(67, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(680, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Location = new System.Drawing.Point(220, 81);
            this.chkUppercase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(97, 20);
            this.chkUppercase.TabIndex = 5;
            this.chkUppercase.Text = "Uppercase";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(632, 21);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(20, 24);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "8";
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Checked = true;
            this.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymbols.Location = new System.Drawing.Point(504, 81);
            this.chkSymbols.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(82, 20);
            this.chkSymbols.TabIndex = 3;
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Location = new System.Drawing.Point(386, 81);
            this.chkDigits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(63, 20);
            this.chkDigits.TabIndex = 1;
            this.chkDigits.Text = "Digits";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Checked = true;
            this.chkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercase.Location = new System.Drawing.Point(65, 81);
            this.chkLowercase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(95, 20);
            this.chkLowercase.TabIndex = 0;
            this.chkLowercase.Text = "Lowercase";
            this.chkLowercase.UseVisualStyleBackColor = true;
            // 
            // trackBarLength
            // 
            this.trackBarLength.Location = new System.Drawing.Point(65, 21);
            this.trackBarLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarLength.Maximum = 64;
            this.trackBarLength.Name = "trackBarLength";
            this.trackBarLength.Size = new System.Drawing.Size(567, 56);
            this.trackBarLength.TabIndex = 2;
            this.trackBarLength.Value = 8;
            this.trackBarLength.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(556, 27);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 34);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(679, 27);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(67, 34);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(77, 28);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(473, 34);
            this.txtPassword.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "PasswordGenerator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.TrackBar trackBarLength;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.CheckBox chkUppercase;
    }
}

