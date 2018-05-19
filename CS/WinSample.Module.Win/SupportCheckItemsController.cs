using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.XtraBars;
using DevExpress.ExpressApp.Win.Templates.ActionContainers.Items;

namespace WinSample.Module.Win {
    public partial class SupportCheckItemsController : WindowController {
        protected override void OnActivated() {
            base.OnActivated();
            DefaultBarActionItemsFactory.CustomizeActionControl += new EventHandler<DevExpress.ExpressApp.Win.Templates.ActionContainers.CustomizeActionControlEventArgs<ActionBase>>(DefaultBarActionItemsFactory_CustomizeActionControl);
        }
        void DefaultBarActionItemsFactory_CustomizeActionControl(object sender, DevExpress.ExpressApp.Win.Templates.ActionContainers.CustomizeActionControlEventArgs<ActionBase> e) {
            if (e.Action is CheckableSimpleAction) {
                e.ActionControl = new CheckActionItem(e.Action, e.ActionControl.Control.Manager);
            }
        }
    }
}
