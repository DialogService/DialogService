using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public class Button : IDialogItem, IContentItem
    {
        private object tag;
        public object Tag 
        {
            get => tag;
            set => tag = value;
        }

        private object content;
        public object Content 
        {
            get => content;
            set => content = value;
        }

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
