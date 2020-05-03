using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// A dialog model
    /// </summary>
    public class Dialog : IDialogItem, ITitleItem, IBigContainerItem
    {
        /// <summary>
        /// Gets dialog bottom panel items list
        /// </summary>
        public IDialogItemList BottomPanel => bottomPanel.Items;
        private Panel bottomPanel = new Panel();

        /// <summary>
        /// Gets dialog items list
        /// </summary>
        public IDialogItemList Items => itemsPanel.Items;
        private Panel itemsPanel = new Panel();

        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets dialog title
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// Creates an empty dialog
        /// </summary>
        public Dialog()
        {
        }

        /// <summary>
        /// Creates a dialog with a specified title text
        /// </summary>
        /// <param name="title">Title text</param>
        public Dialog(string title) : this()
        {
            Title = title;
        }

        /// <summary>
        /// Creates a dialog with specific items
        /// </summary>
        /// <param name="items">Items collection</param>
        public Dialog(IEnumerable<IDialogItem> items) : this()
        {
            Items.AddRange(items);
        }

        /// <summary>
        /// Creates a dialog with a specified title text and specific items
        /// </summary>
        /// <param name="title">Title text</param>
        /// <param name="items">Items collection</param>
        public Dialog(string title, IEnumerable<IDialogItem> items) : this()
        {
            Title = title;
            Items.AddRange(items);
        }
    }
}
