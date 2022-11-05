using System.Collections.Generic;
using System.Windows.Forms;

namespace CSZip.Dialog
{
    public class FolderDialog : IDialogChooser
    {
        private List<string> folders;
        public ItemType Type { get; }

        public List<string> SelectedItems { get => folders; }

        public FolderDialog()
        {
            Type = ItemType.Folder;
            folders = new List<string>();
        }

        public DialogResult ShowDialog()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            folders.Clear();
            folders.Add(dialog.SelectedPath);
            return result;
        }
    }
}
