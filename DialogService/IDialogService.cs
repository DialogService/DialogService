namespace System
{
    public interface IDialogService
    {
        DialogResult Result { get; }
        void Show();
    }
}
