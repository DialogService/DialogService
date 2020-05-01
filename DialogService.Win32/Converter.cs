using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DialogService.Win32
{
    public class Converter
    {
        public List<IControlConverter> Converters = new List<IControlConverter>();

        public IControlConverter GetConverter(Items.IDialogItem item)
            => Converters.Find(x => x.TypeFrom == item.GetType());

        public System.Windows.UIElement GetControl(Items.IDialogItem item)
            => GetConverter(item).Get(this, item);

        public System.Windows.UIElement[] GetControls(IEnumerable<Items.IDialogItem> items)
        {
            var controls = items.Select(x => GetConverter(x).Get(this, x));
            return controls.ToArray();
        }
    }
}
