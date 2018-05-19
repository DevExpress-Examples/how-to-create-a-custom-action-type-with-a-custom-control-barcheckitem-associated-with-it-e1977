using System;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win.Templates.ActionContainers.Items;
using DevExpress.XtraBars;

namespace Solution5.Module.Win
{
    public class CheckableSimpleActionItem : BarActionBaseItem
    {
        public CheckableSimpleActionItem(ActionBase action, BarManager manager) : base(action, manager) { }

        protected override void ItemClicked(BarItemLink barItemLink) {
            base.ItemClicked(barItemLink);
            if (IsItemClickEnable && IsConfirmed()) {
                Action.Checked = !Action.Checked;
            }
        }

        protected override BarItem CreateControlCore()
        {
            return new BarCheckItem();
        }

        public void Execute()
        {
            ItemClicked(null);
        }

        protected override void SynchronizeWithActionCore()
        {
            base.SynchronizeWithActionCore();
            Control.Checked = Action.Checked;
            Action.CheckedStateChanged += new EventHandler(Action_CheckedStateChanged);
        }

        void Action_CheckedStateChanged(object sender, EventArgs e)
        {
            Control.Checked = Action.Checked;
        }

        public new BarCheckItem Control
        {
            get
            {
                return (BarCheckItem)base.Control;
            }
        }
        public new CheckableSimpleAction Action
        {
            get
            {
                return (CheckableSimpleAction)base.Action;
            }
        }
    }
}