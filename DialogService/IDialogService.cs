using DialogService.Items;

namespace DialogService
{
    /// <summary>
    /// Defines basic dialog-related functionality
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// Shows a dialog
        /// </summary>
        /// <param name="dialog">Dialog model</param>
        void Show(Dialog dialog);
    }
}
