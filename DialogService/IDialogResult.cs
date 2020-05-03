using DialogService.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public interface IDialogResult
    {
        /// <summary>
        /// Gets or sets <see cref="IDialogItem"/> instance that caused current dialog to close. 
        /// </summary>
        IDialogItem ClosedBy { get; set; }
    }
}
