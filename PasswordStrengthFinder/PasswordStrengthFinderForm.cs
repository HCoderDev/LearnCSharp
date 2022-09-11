using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStrengthFinder
{
    public partial class PasswordStrengthFinderForm : Form
    {
        PasswordValidator passwordValidator = new PasswordValidator();
        public PasswordStrengthFinderForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == string.Empty) return;
            
            string message = string.Empty;
            if(passwordValidator.IsStrong(txtPassword.Text,out message))
            {
                if (string.IsNullOrEmpty(message))
                    lblPasswordOutput.Text = "Password strong enough.Good to go";
                else
                    lblPasswordOutput.Text = message;
            }
            else
            {
                lblPasswordOutput.Text = message;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSetPassword.PerformClick();
            }
        }
    }
}
