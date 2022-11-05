using CSZip.Dialog;
using Ionic.Zip;
using System;
using System.IO;

using System.Windows.Forms;

namespace CSZip
{
    public partial class MainForm : Form
    {
        IDialogChooser currentDialog;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            currentDialog = DialogFactory.GetDialog(chkFile.Checked);
            DialogResult dialogResult = currentDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if(currentDialog.Type == ItemType.File)
                {
                    if(currentDialog.SelectedItems.Count > 1)
                    {
                        txtSelectedFileFolder.Text = $"{currentDialog.SelectedItems.Count} files selected.";
                    }
                    else
                    {
                        txtSelectedFileFolder.Text = currentDialog.SelectedItems[0].ToString();
                    }
                }
                else
                {
                    txtSelectedFileFolder.Text = currentDialog.SelectedItems[0].ToString();
                }
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip File | *.zip";
            DialogResult result = saveFileDialog.ShowDialog();


            if(result == DialogResult.OK)
            {
               if(currentDialog.Type == ItemType.File)
                {
                    using (ZipFile zipFile =new ZipFile(saveFileDialog.FileName))
                    {
                        setPassword(zipFile);
                        foreach(string sourceFileName in currentDialog.SelectedItems)
                        {
                            zipFile.AddFile(sourceFileName, Path.GetFileName(sourceFileName));
                        }
                        zipFile.Save();
                    }
                }
                else
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        File.Delete(saveFileDialog.FileName);
                    }

                    using (ZipFile zipFile = new ZipFile(saveFileDialog.FileName))
                    {
                        setPassword(zipFile);
                        zipFile.AddDirectory(currentDialog.SelectedItems[0].ToString());
                        zipFile.Save();
                    }

                }
            }
           
        }

        private void setPassword(ZipFile zipFile)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                zipFile.Password = txtPassword.Text;
                zipFile.Encryption = EncryptionAlgorithm.WinZipAes256;
            }
        }

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            IDialogChooser dialog = DialogFactory.GetDialog(false);
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                using (ZipFile zipFile = new ZipFile(currentDialog.SelectedItems[0]))
                {
                    setPassword(zipFile);
                    zipFile.ExtractAll(dialog.SelectedItems[0].ToString());
                }
                MessageBox.Show("Extraction Completed","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }
    }
}
