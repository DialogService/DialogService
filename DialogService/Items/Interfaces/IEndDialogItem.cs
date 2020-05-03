using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    /// <summary>
    /// Defines an <see cref="IDialogItem"/> that ends dialog on user interaction
    /// </summary>
    public interface IEndDialogItem : IDialogItem
    {
        /// <summary>
        /// Ends dialog on interaction if <see cref="true"/>
        /// </summary>
        bool CloseOnInteract { get; set; }
    }
}
