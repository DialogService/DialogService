using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Container for <see cref="IDialogItem"/>
    /// </summary>
    public class Panel : IDialogItem, IBigContainerItem
    {
        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets items flow
        /// </summary>
        public ItemsFlow Flow { get; set; } = ItemsFlow.TopBottom;

        /// <summary>
        /// Gets items list
        /// </summary>
        public IDialogItemList Items { get; private set; } = new DialogItemList();

        /// <summary>
        /// Creates an instance of <see cref="Panel"/>
        /// </summary>
        public Panel() { }

        /// <summary>
        /// Creates an instance of <see cref="Panel"/> and adds items
        /// </summary>
        /// <param name="items">Items to add</param>
        public Panel(IEnumerable<IDialogItem> items)
        {
            Items.AddRange(items);
        }
    }
}
