using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Dialog model
    /// </summary>
    public class Dialog : IDialogItem, ITitleItem, IHolderItem
    {
        /// <summary>
        /// Gets dialog buttons list
        /// </summary>
        public List<IDialogItem> BottomPanel { get; private set; } = new List<IDialogItem>();

        public object Tag { get; set; }

        public string Title { get; set; }

        public List<IDialogItem> Items { get; private set; } = new List<IDialogItem>();

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
