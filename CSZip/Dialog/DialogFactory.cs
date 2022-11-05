namespace CSZip.Dialog
{
    public class DialogFactory
    {
        public static IDialogChooser GetDialog(bool IsFile)
        {
            if (IsFile) return new FileDialog();
            return new FolderDialog();
        }
    }
}
