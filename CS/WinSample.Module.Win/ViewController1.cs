using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Data.Filtering;

namespace WinSample.Module.Win {
    public partial class ViewController1 : ViewController {
        public ViewController1() {
            InitializeComponent();
            RegisterActions(components);
            TargetViewId = "BO1_ListView";
        }
        protected override void OnActivated() {
            base.OnActivated();
            simpleAction1.Checked = false;
        }
        private const string filterValue = "Not IsNull([Property1])";
        private const string filterName = "ListViewFilter";
        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            if (simpleAction1.Checked) {
                ((ListView)View).CollectionSource.Criteria[filterName] = CriteriaOperator.Parse(filterValue);
            } else {
                ((ListView)View).CollectionSource.Criteria.Remove(filterName);
            }
        }
    }
}
