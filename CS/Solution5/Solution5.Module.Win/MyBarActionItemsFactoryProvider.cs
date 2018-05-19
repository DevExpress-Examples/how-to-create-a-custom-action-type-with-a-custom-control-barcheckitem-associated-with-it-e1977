using DevExpress.ExpressApp.Win.Templates;
using DevExpress.XtraBars;

namespace Solution5.Module.Win
{
    public class MyBarActionItemsFactoryProvider : IBarActionItemsFactoryProvider
    {
        public BarActionItemsFactory CreateBarActionItemsFactory(BarManager barManager)
        {
            return new MyBarActionItemsFactory(barManager);
        }
    }
}
