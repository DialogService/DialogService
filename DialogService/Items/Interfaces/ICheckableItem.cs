using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an item that can be checked by user
    /// </summary>
    public interface ICheckableItem : IDialogItem, IEditableItem
    {
        /// <summary>
        /// Gets or sets currect check status.
        /// </summary>
        CheckState CheckState { get; set; }
    }
}
