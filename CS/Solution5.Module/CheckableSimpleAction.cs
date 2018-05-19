using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Actions;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace Solution5.Module
{
    public class CheckableSimpleAction : SimpleAction
    {
        public CheckableSimpleAction(IContainer container) : base(container) { }
        public CheckableSimpleAction(Controller owner, string id, PredefinedCategory category) : base(owner, id, category) { }

        private bool _Checked = false;
        public bool Checked
        {
            get
            {
                return _Checked;
            }
            set
            {
                if (_Checked != value)
                {
                    _Checked = value;
                    DoCheckedStateChanged();
                    if (Enabled.ResultValue && Active.ResultValue)
                    {
                        DoExecute();
                    }
                }
            }
        }

        private void DoCheckedStateChanged()
        {
            if (CheckedStateChanged != null)
            {
                CheckedStateChanged(this, new EventArgs());
            }
        }

        public event EventHandler CheckedStateChanged;
    }
}