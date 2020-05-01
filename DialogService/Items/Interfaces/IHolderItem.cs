using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an item that can hold one or more items inside of it
    /// </summary>
    public interface IHolderItem : IDialogItem
    {
        /// <summary>
        /// Items of current item
        /// </summary>
        List<IDialogItem> Items { get; }
    }
}
