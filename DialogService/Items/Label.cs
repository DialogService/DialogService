using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Text label item
    /// </summary>
    public class Label : IDialogItem, IContainerItem<string>, IEndDialogItem, ITextItem
    {
        public object Tag { get; set; }
        /// <summary>
        /// Gets or sets text value
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Gets or sets value if current dialog must be closed on user interaction with this item
        /// </summary>
        public bool CloseOnInteract { get; set; }
        /// <summary>
        /// Gets or sets <see cref="IFont"/>
        /// </summary>
        public IFont Font { get; set; }

        /// <summary>
        /// Creates a label with specific text
        /// </summary>
        /// <param name="content">Text to display</param>
        public Label(string content = "")
        {
            Content = content;
        }
    }
}
