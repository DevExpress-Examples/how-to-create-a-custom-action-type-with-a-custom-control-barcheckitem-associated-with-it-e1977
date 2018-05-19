using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Win.Templates.ActionContainers.Items;
using DevExpress.XtraBars;
using DevExpress.ExpressApp.Actions;

namespace WinSample.Module.Win {
    public class CheckActionItem : ItemBase {
        public CheckActionItem(ActionBase action, BarManager manager) : base(action, manager) { }
        
        protected override void ItemClicked() {
            base.ItemClicked();
            if (IsItemClickEnable && IsConfirmed()) {
                Action.Checked = !Action.Checked;
            }
        }

        protected override BarItem CreateControlCore() {
            return new BarCheckItem();
        }

         public void Execute() {
            ItemClicked();
        }

        protected override void SynchronizeWithActionCore() {
            base.SynchronizeWithActionCore();
            Control.Checked = Action.Checked;
            Action.CheckedStateChanged += new EventHandler(Action_CheckedStateChanged);
        }

        void Action_CheckedStateChanged(object sender, EventArgs e) {
            Control.Checked = Action.Checked;
        }

        public new BarCheckItem Control {
            get {
                return (BarCheckItem)base.Control;
            }
        }
        public new CheckableSimpleAction Action {
            get {
                return (CheckableSimpleAction)base.Action;
            }
        }
    }
}
