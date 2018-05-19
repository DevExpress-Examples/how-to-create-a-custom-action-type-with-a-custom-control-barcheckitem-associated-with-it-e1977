using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Templates;

namespace Solution5.Module.Win
{
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class Solution5WindowsFormsModule : ModuleBase
    {
        public Solution5WindowsFormsModule()
        {
            InitializeComponent();
            BarActionItemsFactoryProvider.Instance = new MyBarActionItemsFactoryProvider();
        }
    }
}
