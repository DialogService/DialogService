using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    /// <summary>
    /// IDialogService builder for platform
    /// </summary>
    public abstract class AbstractPlatform
    {
        /// <summary>
        /// Gets target platforms
        /// </summary>
        public abstract IEnumerable<RuntimePlatform> Platform { get; }

        /// <summary>
        /// Gets IDialogService implementation
        /// </summary>
        /// <returns></returns>
        public abstract IDialogService Get();
    }
}
