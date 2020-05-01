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

            dialog.Items.Add(new Button("Click me"));
            dialog.Items.Add(new Label("This is the label!"));

            dialog.Buttons.Add(new Button("OK"));
            dialog.Buttons.Add(new Button("Cancel"));

            dialogService.Show(dialog);
        }
    }
}
