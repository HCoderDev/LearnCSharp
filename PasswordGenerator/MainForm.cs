using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblLength.Text = trackBarLength.Value.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = PasswordGenHelper.GeneratePassword(GetGenerateConfig());
        }

        private GenerateConfig GetGenerateConfig()
        {
            GenerateConfig config = new GenerateConfig();
            config.IsLowerCase = chkLowercase.Checked;
            config.IsUpperCase = chkUppercase.Checked;
            config.IsDigits = chkDigits.Checked;
            config.IsSymbols= chkSymbols.Checked;
            config.Length = trackBarLength.Value;
            return config;
        }

      

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }
    }
}
