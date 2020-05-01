using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an item with title
    /// </summary>
    public interface ITitleItem : IDialogItem
    {
        /// <summary>
        /// Gets or sets title of the item
        /// </summary>
        string Title { get; set; }
    }
}
