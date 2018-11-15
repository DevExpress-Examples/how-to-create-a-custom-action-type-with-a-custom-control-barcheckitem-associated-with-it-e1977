<!-- default file list -->
*Files to look at*:

* [CheckableSimpleActionItem.cs](./CS/Solution5.Module.Win/CheckableSimpleActionItem.cs) (VB: [CheckableSimpleActionItem.vb](./VB/Solution5.Module.Win/CheckableSimpleActionItem.vb))
* [MyBarActionItemsFactory.cs](./CS/Solution5.Module.Win/MyBarActionItemsFactory.cs) (VB: [MyBarActionItemsFactory.vb](./VB/Solution5.Module.Win/MyBarActionItemsFactory.vb))
* [MyBarActionItemsFactoryProvider.cs](./CS/Solution5.Module.Win/MyBarActionItemsFactoryProvider.cs) (VB: [MyBarActionItemsFactoryProvider.vb](./VB/Solution5.Module.Win/MyBarActionItemsFactoryProvider.vb))
* [WinModule.cs](./CS/Solution5.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/Solution5.Module.Win/WinModule.vb))
* [CheckableSimpleAction.cs](./CS/Solution5.Module/CheckableSimpleAction.cs) (VB: [CheckableSimpleAction.vb](./VB/Solution5.Module/CheckableSimpleAction.vb))
<!-- default file list end -->
# How to create a custom action type with a custom control (BarCheckItem), associated with it


<p>This example demonstrates how to represent an action via the BarCheckItem. For this purpose, an ActionBase descendant (CheckableSimpleAction) is implemented. This is done because it is required to save the checked state of the action. CheckableSimpleAction uses a custom action item (CheckActionItem), which represents it in the UI via a BarCheckItem. Action item is a connector between the abstract entity Action and a particular UI element. When the form's menu is created, XAF creates action items for all actions placed to this form via action containers. This operation is performed by the BarActionItemsFactory and the <a href="http://help.devexpress.com/#eXpressAppFramework/clsDevExpressExpressAppSystemModuleActionControlsSiteControllertopic">ActionControlsSiteController</a>. Since we have implemented a custom action type, it is required to implement a custom BarActionItemsFactory to assign an appropriate action item to actions of this type. The custom BarActionItemsFactory is registered via the custom factory provider (MyBarActionItemsFactoryProvider).<br> Note that in most cases, it is not required to implement a custom action and action item. It is sufficient to customize the existing action item via the BarActionItemsFactory.CustomizeActionControl event. This approach is demonstrated in the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3183"><u>How to: Customize Controls Associated with an Action</u></a> topic.<br> An example for ASP.NET is available here: <a href="https://www.devexpress.com/Support/Center/p/E4357">How to create a custom action type with a custom control in Web</a></p>

<br/>


