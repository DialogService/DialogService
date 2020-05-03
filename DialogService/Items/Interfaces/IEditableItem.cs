using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// An item that can be modified by user
    /// </summary>
    public interface IEditableItem : IDialogItem
    {
        /// <summary>
        /// Gets or sets value if this item can be modified by user
        /// </summary>
        bool AllowModification { get; set; }
    }
}
