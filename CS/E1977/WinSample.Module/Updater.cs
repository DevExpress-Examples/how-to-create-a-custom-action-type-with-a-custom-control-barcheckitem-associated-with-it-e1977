using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace WinSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.GetObjectsCount(typeof(BO1), null) == 0) {
                BO1 bo1 = ObjectSpace.CreateObject<BO1>();
                bo1.Save();
                bo1 = ObjectSpace.CreateObject<BO1>();
                bo1.Property1 = "test";
                bo1.Save();
            }
        }
    }
}
