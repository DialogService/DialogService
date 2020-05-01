using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public class PlatformImplementation
    {
        /// <summary>
        /// Gets Win32 dialog service implementation
        /// </summary>
        /// <returns></returns>
        public static IDialogService Get() => new Win32.Win32DialogService();
    }
}
