using System.Collections.Generic;
using System.Windows.Forms;

namespace CSZip.Dialog
{
    public enum ItemType
    {
        File, Folder
    }
    public interface IDialogChooser
    {
        ItemType Type { get; }
        List<string> SelectedItems { get; }
        DialogResult ShowDialog();
    }
}
