using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    public class Button : IDialogItem, IContainerItem, IEndDialogItem
    {
        public object Tag { get; set; }
        /// <summary>
        /// Gets or sets content
        /// </summary>
        public IDialogItem Content { get; set; }
        /// <summary>
        /// Get or sets value if this dialog must be closed on user interaction with current instance
        /// </summary>
        public bool CloseOnInteract { get; set; } = true;

        /// <summary>
        /// Creates an empty button
        /// </summary>
        public Button()
        { }

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
