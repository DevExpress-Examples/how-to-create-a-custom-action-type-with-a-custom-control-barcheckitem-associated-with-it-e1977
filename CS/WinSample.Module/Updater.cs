using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (new XPCollection<BO1>(Session).Count == 0) {
                BO1 bo1 = new BO1(Session);
                bo1.Save();
                bo1 = new BO1(Session);
                bo1.Property1 = "test";
                bo1.Save();
            }
        }
    }
}
