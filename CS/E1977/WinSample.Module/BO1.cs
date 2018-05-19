using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinSample.Module {
    [DefaultClassOptions]
    public class BO1 : BaseObject {
        public BO1(Session session) : base(session) { }
        private string _Property1;
        public string Property1 {
            get { return _Property1; }
            set { SetPropertyValue("Property1", ref _Property1, value); }
        }
    }
}
