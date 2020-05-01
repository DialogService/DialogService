using DialogService.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DialogService.Win32
{
    public class ButtonConverter : IControlConverter
    {
        public Type TypeFrom { get; private set; } = typeof(Button);

        public System.Windows.UIElement Get(Converter converter, Items.IDialogItem from)
        {
            if (from.GetType() == TypeFrom)
            {
                var btn = (Button)from;
                var ctrl = new System.Windows.Controls.Button();
                ctrl.Content = converter.GetControl(btn.Content);
                ctrl.Margin = new System.Windows.Thickness(5);
                return ctrl;
            }

            throw new NotSupportedException();
        }
    }
}
