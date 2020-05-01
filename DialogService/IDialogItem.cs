using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    /// <summary>
    /// Defines dialog item
    /// </summary>
    public interface IDialogItem
    {
        /// <summary>
        /// Item's tag
        /// </summary>
        object Tag { get; set; }
    }
}
