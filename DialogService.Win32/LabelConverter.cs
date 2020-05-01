using DialogService.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DialogService.Win32
{
    public class LabelConverter : IControlConverter
    {
        public Type TypeFrom { get; private set; } = typeof(Label);

        public System.Windows.UIElement Get(Converter converter, Items.IDialogItem from)
        {
            if (from.GetType() == TypeFrom)
            {
                var label = (Label)from;
                var ctrl = new System.Windows.Controls.TextBlock();
                ctrl.Text = label.Content;
                ctrl.Margin = new System.Windows.Thickness(3);
                return ctrl;
            }

            throw new NotSupportedException();
        }
    }
}
