using System;

namespace DialogService.CrossPlatform
{
    public class DialogService
    {
        /// <summary>
        /// Get's dialog service implementation for current platform
        /// </summary>
        public static IDialogService Get()
        {
            return new PlatformImplementation().Get();
        }
    }
}
