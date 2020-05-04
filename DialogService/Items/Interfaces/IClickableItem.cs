using System;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an item that can be clicked with mouse buttons
    /// </summary>
    public interface IClickableItem : IDialogItem
    {
        event EventHandler OnMouseButtonDown;
        event EventHandler OnMouseButtonUp;
    }
}
