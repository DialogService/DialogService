using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Items
{
    public class RadioBox : IDialogItem, IContainerItem, ICheckableItem, IEndDialogItem
    {
        public object Tag { get; set; }
        /// <summary>
        /// Gets or sets current check state
        /// </summary>
        public CheckState CheckState { get; set; } = CheckState.Unchecked;
        /// <summary>
        /// Gets or sets value if <see cref="CheckState"/> can be changed by user
        /// </summary>
        public bool AllowModification { get; set; } = true;
        /// <summary>
        /// Gets or sets value if current dialog must be closed by interaction with this item
        /// </summary>
        public bool CloseOnInteract { get; set; }
        /// <summary>
        /// Gets or sets content
        /// </summary>
        public IDialogItem Content { get; set; }
    }
}
