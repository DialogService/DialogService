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
            dialogService.Show();
        }
    }
}
