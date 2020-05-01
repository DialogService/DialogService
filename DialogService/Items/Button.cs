using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    public class Button : IDialogItem, IContentItem
    {
        public object Tag { get; set; }

        public IDialogItem Content { get; set; }

        /// <summary>
        /// Creates an empty button
        /// </summary>
        public Button()
        {
        }

        /// <summary>
        /// Creates a button with specific content
        /// </summary>
        /// <param name="content">Content</param>
        public Button(IDialogItem content) : this()
        {
            Content = content;
        }

        /// <summary>
        /// Creates a button with new instance of <see ref="Label"/>
        /// </summary>
        /// <param name="textLabel"></param>
        public Button(string textLabel) : this(new Label(textLabel))
        { }
    }
}
