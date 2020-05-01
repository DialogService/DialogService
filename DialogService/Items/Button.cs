using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    public class Button : IDialogItem, IContentItem
    {
        public object Tag { get; set; }

        public object Content { get; set; }

        /// <summary>
        /// Creates an empty button
        /// </summary>
        public Button()
        {
        }

        /// <summary>
        /// Creates button with specific content
        /// </summary>
        /// <param name="content">Content</param>
        public Button(string content) : this()
        {
            Content = content;
        }
    }
}
