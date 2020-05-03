using DialogService.Items;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DialogService
{
    public static class IDialogServiceExtensions
    {
        private static string DefaultTitle => Assembly.GetCallingAssembly().Location;

        /// <summary>
        /// Shows a message dialog with default title and OK button
        /// </summary>
        /// <param name="dialogService">Dialog service instance</param>
        /// <param name="text">A text to show</param>
        /// <returns>Pressed button</returns>
        public static MessageBoxButton ShowMessageBox(this IDialogService dialogService, string text)
            => ShowMessageBox(dialogService, new Label(text));

        /// <summary>
        /// Shows a message dialog with default title and OK button
        /// </summary>
        /// <param name="dialogService">Dialog service instance</param>
        /// <param name="content">A content to show</param>
        /// <returns>Pressed button</returns>
        public static MessageBoxButton ShowMessageBox(this IDialogService dialogService, IDialogItem content)
            => ShowMessageBox(dialogService, content, DefaultTitle);

        /// <summary>
        /// Shows a message dialog with specified title and OK button
        /// </summary>
        /// <param name="dialogService">Dialog service instance</param>
        /// <param name="text">A text to show</param>
        /// <param name="title">A window title</param>
        /// <returns>Pressed button</returns>
        public static MessageBoxButton ShowMessageBox(this IDialogService dialogService, string text, string title)
            => ShowMessageBox(dialogService, new Label(text), title);

        /// <summary>
        /// Shows a message dialog with specified title and OK button
        /// </summary>
        /// <param name="dialogService">Dialog service instance</param>
        /// <param name="content">A content to show</param>
        /// <param name="title">A window title</param>
        /// <returns>Pressed button</returns>
        public static MessageBoxButton ShowMessageBox(this IDialogService dialogService, IDialogItem content, string title)
            => ShowMessageBox(dialogService, content, title, MessageBoxButtons.OK);

        /// <summary>
        /// Shows a message dialog
        /// </summary>
        /// <param name="dialogService">Dialog service instance</param>
        /// <param name="text">A text to show</param>
        /// <param name="title">A window title</param>
        /// <param name="buttons">Buttons to show</param>
        /// <returns>Pressed button</returns>
        public static MessageBoxButton ShowMessageBox(this IDialogService dialogService, string text, string title, MessageBoxButtons buttons)
            => ShowMessageBox(dialogService, new Label(text), title, buttons);

        /// <summary>
        /// Shows a message dialog
        /// </summary>
        /// <param name="dialogService">Dialog service instance</param>
        /// <param name="content">A content to show</param>
        /// <param name="title">A window title</param>
        /// <param name="buttons">Buttons to show</param>
        /// <returns>Pressed button</returns>
        public static MessageBoxButton ShowMessageBox(this IDialogService dialogService, IDialogItem content, string title, MessageBoxButtons buttons)
        {
            var dialogButtons = new List<Button>();

            if (buttons == MessageBoxButtons.OK)
                dialogButtons.Add(new Button("OK") { Tag = MessageBoxButton.OK });
            else if (buttons == MessageBoxButtons.YesNo)
                dialogButtons.AddRange(new Button[] {
                    new Button("Yes") { Tag = MessageBoxButton.Yes },
                    new Button("No") { Tag = MessageBoxButton.No }});
            else if (buttons == MessageBoxButtons.YesNoCancel)
                dialogButtons.AddRange(new Button[] {
                    new Button("Yes") { Tag = MessageBoxButton.Yes },
                    new Button("No") { Tag = MessageBoxButton.No },
                    new Button("Cancel") { Tag = MessageBoxButton.Cancel }});
            else if (buttons == MessageBoxButtons.RetryAbort)
                dialogButtons.AddRange(new Button[] {
                    new Button("Retry") { Tag = MessageBoxButton.Retry },
                    new Button("Abort") { Tag = MessageBoxButton.Abort }});

            var dialog = new Dialog(title, new IDialogItem[] { content });
            dialog.BottomPanel.AddRange(dialogButtons);

            var result = dialogService.Show(dialog);

            if (result.ClosedBy == null) return MessageBoxButton.Cancel;
            else return (MessageBoxButton)((Button)result.ClosedBy).Tag;
        }
    }
}
