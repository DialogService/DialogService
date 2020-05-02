using DialogService.Items;
using System;

namespace DialogService.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DialogService Test Application");

            var dialogService = CrossPlatform.DialogService.Get(); // get's implementation for current platform
            var dialog = new Dialog("Test Dialog"); // create a dialog model with title

            dialog.Items.Add(new Button("Click me"));
            dialog.Items.Add(new Label("This is the label!"));

            dialog.BottomPanel.Add(new Button("OK"));
            dialog.BottomPanel.Add(new Button("Cancel"));

            dialogService.Show(dialog);

            Console.WriteLine("Finished");
        }
    }
}
