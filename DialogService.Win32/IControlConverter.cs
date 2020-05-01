using DialogService.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService.Win32
{
    public interface IControlConverter
    {
        Type TypeFrom { get; }

        System.Windows.UIElement Get(Converter converter, IDialogItem from);
    }
}
