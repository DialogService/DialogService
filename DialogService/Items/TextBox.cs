using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// An editable by user text box
    /// </summary>
    public class TextBox : IDialogItem, IContainerItem<string>, ITextItem, IEditableItem
    {
        /// <summary>
        /// Gets or sets a tag
        /// </summary>
        public object Tag { get; set; }
        /// <summary>
        /// Gets or sets text value
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Gets or sets <see cref="IFont"/>
        /// </summary>
        public IFont Font { get; set; }
        /// <summary>
        /// Gets or sets value if this <see cref="TextBox"/> can be modified by user
        /// </summary>
        public bool AllowModification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
