using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Text label item
    /// </summary>
    public class Label : IDialogItem, IContentItem<string>
    {
        public object Tag { get; set; }
        public string Content { get; set; }

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
