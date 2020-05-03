using DialogService.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public class DialogResult : IDialogResult
    {
        public IDialogItem ClosedBy { get; set; }

        public DialogResult() { }

        public DialogResult(IDialogItem closedBy)
        {
            ClosedBy = closedBy;
        }
    }
}
