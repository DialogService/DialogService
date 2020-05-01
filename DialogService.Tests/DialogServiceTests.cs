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
            dialogService.Show(dialog);
        }
    }
}
