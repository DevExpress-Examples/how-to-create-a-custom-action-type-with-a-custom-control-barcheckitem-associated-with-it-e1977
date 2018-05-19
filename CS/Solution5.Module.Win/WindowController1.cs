using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace Solution5.Module.Win
{
    public class WindowController1 : WindowController
    {
        public WindowController1()
        {
            CheckableSimpleAction action = new CheckableSimpleAction(this, "TestAction", PredefinedCategory.RecordEdit);
        }
    }
  
   
}
