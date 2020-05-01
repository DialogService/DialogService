using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public class PlatformImplementation
    {
        /// <summary>
        /// Gets MacOS dialog service implementation
        /// </summary>
        /// <returns></returns>
        public static IDialogService Get() => new MacOS.MacOSDialogService();
    }
}
