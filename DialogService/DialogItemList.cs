using DialogService.Items;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DialogService
{
    public class DialogItemList : IDialogItemList
    {
        private List<IDialogItem> items = new List<IDialogItem>();

        public IDialogItem this[int index] { get => ((IList<IDialogItem>)items)[index]; set => ((IList<IDialogItem>)items)[index] = value; }
        object IList.this[int index] { get => ((IList)items)[index]; set => ((IList)items)[index] = value; }

        public int Count => ((ICollection<IDialogItem>)items).Count;

        public bool IsReadOnly => ((ICollection<IDialogItem>)items).IsReadOnly;

        public bool IsSynchronized => ((ICollection)items).IsSynchronized;

        public object SyncRoot => ((ICollection)items).SyncRoot;

        public bool IsFixedSize => ((IList)items).IsFixedSize;

        public void Add(IDialogItem item)
        {
            ((ICollection<IDialogItem>)items).Add(item);
        }

        public void AddRange(IEnumerable<IDialogItem> items)
        {
            this.items.AddRange(items);
        }

        public int Add(object value)
        {
            return ((IList)items).Add(value);
        }

        public void Clear()
        {
            ((ICollection<IDialogItem>)items).Clear();
        }

        public bool Contains(IDialogItem item)
        {
            return ((ICollection<IDialogItem>)items).Contains(item);
        }

        public bool Contains(object value)
        {
            return ((IList)items).Contains(value);
        }

        public void CopyTo(IDialogItem[] array, int arrayIndex)
        {
            ((ICollection<IDialogItem>)items).CopyTo(array, arrayIndex);
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)items).CopyTo(array, index);
        }

        public IEnumerator<IDialogItem> GetEnumerator()
        {
            return ((ICollection<IDialogItem>)items).GetEnumerator();
        }

        public int IndexOf(IDialogItem item)
        {
            return ((IList<IDialogItem>)items).IndexOf(item);
        }

        public int IndexOf(object value)
        {
            return ((IList)items).IndexOf(value);
        }

        public void Insert(int index, IDialogItem item)
        {
            ((IList<IDialogItem>)items).Insert(index, item);
        }

        public void Insert(int index, object value)
        {
            ((IList)items).Insert(index, value);
        }

        public bool Remove(IDialogItem item)
        {
            return ((ICollection<IDialogItem>)items).Remove(item);
        }

        public void Remove(object value)
        {
            ((IList)items).Remove(value);
        }

        public void RemoveAt(int index)
        {
            ((IList<IDialogItem>)items).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<IDialogItem>)items).GetEnumerator();
        }
    }
}
