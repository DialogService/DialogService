using DialogService.Items;
using System.Collections;
using System.Collections.Generic;

namespace DialogService
{
    /// <summary>
    /// An <see cref="IDialogItem"/> container
    /// </summary>
    public interface IDialogItemList : ICollection<IDialogItem>, IEnumerable<IDialogItem>, IEnumerable, IList<IDialogItem>, IReadOnlyCollection<IDialogItem>, IReadOnlyList<IDialogItem>, ICollection, IList
    {
        void AddRange(IEnumerable<IDialogItem> items);
    }
}
