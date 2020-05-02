using DialogService.Items;
using System;
using System.Runtime.InteropServices;
using Xunit;

namespace DialogService.Tests
{
    public class DialogServiceTests
    {
        [Fact]
        public void PlatformTest()
        {
            var dialogService = CrossPlatform.DialogService.Get();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Assert.Contains("Win32", dialogService.GetType().Name);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                Assert.Contains("Linux", dialogService.GetType().Name);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                Assert.Contains("MacOS", dialogService.GetType().Name);
            else throw new NotImplementedException();
        }
    }
}
