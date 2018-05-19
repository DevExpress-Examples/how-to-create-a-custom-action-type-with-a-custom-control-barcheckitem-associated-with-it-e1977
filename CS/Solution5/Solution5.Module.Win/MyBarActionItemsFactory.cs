﻿using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Templates.ActionContainers.Items;
using DevExpress.XtraBars;

namespace Solution5.Module.Win
{
    public class MyBarActionItemsFactory : BarActionItemsFactory
    {
        public MyBarActionItemsFactory(BarManager manager)
            : base(manager)
        {
        }
        protected override BarActionBaseItem CreateActionItem(ActionBase action)
        {
            if (action is CheckableSimpleAction)
            {
                return new CheckableSimpleActionItem(action, Manager);
            }
            return base.CreateActionItem(action);
        }
    }
}
