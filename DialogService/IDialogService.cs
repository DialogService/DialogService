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
        /// <returns>Summary of dialog interaction <see cref="IDialogResult"/></returns>
        IDialogResult Show(Dialog dialog);
    }
}
