using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    public abstract class AbstractPlatform
    {
        public abstract IDialogService Get();
    }
}
