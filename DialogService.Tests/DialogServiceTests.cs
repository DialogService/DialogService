using DialogService.Items;
using System;
using Xunit;

namespace DialogService.Tests
{
    public class DialogServiceTests
    {
        [Fact]
        public void BasicDialogTest()
        {
            var dialogService = CrossPlatform.DialogService.Get();
            var dialog = new Dialog("Test Dialog");

            for (int i = 0; i < 5; i++)
            {
                dialog.Items.Add(new Button("Click me"));
                dialog.Items.Add(new Label("This is the label!"));
            }

            dialog.BottomPanel.Add(new Button("OK"));
            dialog.BottomPanel.Add(new Button("Cancel"));

            dialogService.Show(dialog);
        }
    }
}
