using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an item that can hold one or more items inside of it
    /// </summary>
    public interface IBigContainerItem : IDialogItem
    {
        /// <summary>
        /// Gets items list of current item
        /// </summary>
        IDialogItemList Items { get; }
    }
}
