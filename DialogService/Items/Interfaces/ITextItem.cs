using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an item that has text with some font settings
    /// </summary>
    public interface ITextItem : IDialogItem
    {
        IFont Font { get; }
    }
}
