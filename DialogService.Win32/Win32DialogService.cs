using DialogService.Items;
using System;
using System.Threading;

namespace DialogService.Win32
{
    /// <summary>
    /// Dialog service implementation for Windows
    /// </summary>
    public class Win32DialogService : IDialogService
    {
        public void Show(Dialog dialog)
        {
            var thread = new Thread(() => ShowThread(dialog));

            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();

            while (thread.IsAlive)
                Thread.Sleep(300);
        }

        private void ShowThread(Dialog dialog)
        {
            var mainForm = new MainWindow();

            var converter = new Converter();
            converter.Converters.Add(new LabelConverter());
            converter.Converters.Add(new ButtonConverter());

            mainForm.Title = dialog.Title;

            // Converting bottom panel
            var bottomControls = converter.GetControls(dialog.BottomPanel);
            foreach (var ctrl in bottomControls)
                mainForm.BottomPanel.Children.Add(ctrl);

            // Converting main controls
            var mainControls = converter.GetControls(dialog.Items);
            foreach (var ctrl in mainControls)
                mainForm.MainPanel.Children.Add(ctrl);

            mainForm.ShowDialog();
        }
    }
}
