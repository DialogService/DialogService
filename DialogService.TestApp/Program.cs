using DialogService.Items;
using System;

namespace DialogService.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DialogService Test Application");

            var dsBuilder = new DialogPlatformBuilder();
            dsBuilder.AddPlatform<Win32.PlatformImplementation>();
            dsBuilder.AddPlatform<Linux.PlatformImplementation>();
            dsBuilder.AddPlatform<MacOS.PlatformImplementation>();
            var dialogService = dsBuilder.GetService();

            var dialog = new Dialog();
            dialog.Title = "The Dialog";

            dialog.Items.Add(new Button("Click me"));
            dialog.Items.Add(new Label("This is the label!"));

            dialog.BottomPanel.Add(new Button("OK"));
            dialog.BottomPanel.Add(new Button("Cancel"));

            dialogService.Show(dialog);

            Console.WriteLine("Finished");
        }
    }
}
