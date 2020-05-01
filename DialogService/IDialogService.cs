namespace DialogService
{
    public interface IDialogService
    {
        DialogResult Result { get; }
        void Show();
    }
}
