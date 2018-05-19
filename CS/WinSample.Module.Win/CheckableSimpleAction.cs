using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using System.ComponentModel;

namespace WinSample.Module.Win {
    public class CheckableSimpleAction : SimpleAction {
        public CheckableSimpleAction(IContainer container) : base(container) { }

        private bool _Checked = false;
        public bool Checked {
            get {
                return _Checked;
            }
            set {
                if (_Checked != value) {
                    _Checked = value;
                    DoCheckedStateChanged();
                    if (Enabled.ResultValue && Active.ResultValue) {
                        DoExecute();
                    }
                }
            }
        }

        private void DoCheckedStateChanged() {
            if (CheckedStateChanged != null) {
                CheckedStateChanged(this, new EventArgs());
            }
        }

        public event EventHandler CheckedStateChanged;
    }
}
