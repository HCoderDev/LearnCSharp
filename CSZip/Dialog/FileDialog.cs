using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSZip.Dialog
{
    public class FileDialog:IDialogChooser
    {
        private List<string> files;
        public ItemType Type { get; }

        public List<string> SelectedItems { get => files; }

        public FileDialog()
        {
            Type = ItemType.File;
            files = new List<string>();
        }

        public DialogResult ShowDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            var result = dialog.ShowDialog();
            files = dialog.FileNames.ToList();
            return result;
        }
    }
}
