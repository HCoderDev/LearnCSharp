namespace CurrencyConverter
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
            this.txtFromCurrency = new System.Windows.Forms.TextBox();
            this.txtToCurrency = new System.Windows.Forms.TextBox();
            this.cmbFromCurrency = new System.Windows.Forms.ComboBox();
            this.cmbToCurrency = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFromCuurency = new System.Windows.Forms.Label();
            this.lblToCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFromCurrency
            // 
            this.txtFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromCurrency.Location = new System.Drawing.Point(111, 79);
            this.txtFromCurrency.Name = "txtFromCurrency";
            this.txtFromCurrency.Size = new System.Drawing.Size(181, 38);
            this.txtFromCurrency.TabIndex = 0;
            // 
            // txtToCurrency
            // 
            this.txtToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCurrency.Location = new System.Drawing.Point(817, 76);
            this.txtToCurrency.Name = "txtToCurrency";
            this.txtToCurrency.Size = new System.Drawing.Size(176, 38);
            this.txtToCurrency.TabIndex = 1;
            // 
            // cmbFromCurrency
            // 
            this.cmbFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromCurrency.FormattingEnabled = true;
            this.cmbFromCurrency.Location = new System.Drawing.Point(308, 79);
            this.cmbFromCurrency.Name = "cmbFromCurrency";
            this.cmbFromCurrency.Size = new System.Drawing.Size(443, 37);
            this.cmbFromCurrency.TabIndex = 2;
            // 
            // cmbToCurrency
            // 
            this.cmbToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToCurrency.FormattingEnabled = true;
            this.cmbToCurrency.Location = new System.Drawing.Point(1025, 77);
            this.cmbToCurrency.Name = "cmbToCurrency";
            this.cmbToCurrency.Size = new System.Drawing.Size(382, 37);
            this.cmbToCurrency.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(682, 160);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(124, 49);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFromCuurency
            // 
            this.lblFromCuurency.AutoSize = true;
            this.lblFromCuurency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromCuurency.Location = new System.Drawing.Point(106, 25);
            this.lblFromCuurency.Name = "lblFromCuurency";
            this.lblFromCuurency.Size = new System.Drawing.Size(142, 25);
            this.lblFromCuurency.TabIndex = 5;
            this.lblFromCuurency.Text = "From Currency";
            // 
            // lblToCurrency
            // 
            this.lblToCurrency.AutoSize = true;
            this.lblToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCurrency.Location = new System.Drawing.Point(812, 25);
            this.lblToCurrency.Name = "lblToCurrency";
            this.lblToCurrency.Size = new System.Drawing.Size(121, 25);
            this.lblToCurrency.TabIndex = 6;
            this.lblToCurrency.Text = "To Currency";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 238);
            this.Controls.Add(this.lblToCurrency);
            this.Controls.Add(this.lblFromCuurency);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbToCurrency);
            this.Controls.Add(this.cmbFromCurrency);
            this.Controls.Add(this.txtToCurrency);
            this.Controls.Add(this.txtFromCurrency);
            this.Name = "MainForm";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFromCurrency;
        private System.Windows.Forms.TextBox txtToCurrency;
        private System.Windows.Forms.ComboBox cmbFromCurrency;
        private System.Windows.Forms.ComboBox cmbToCurrency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFromCuurency;
        private System.Windows.Forms.Label lblToCurrency;
    }
}

