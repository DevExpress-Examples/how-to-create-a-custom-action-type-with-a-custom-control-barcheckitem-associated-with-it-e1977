Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win.Templates
Imports DevExpress.XtraBars

Namespace Solution5.Module.Win
	Public Class MyBarActionItemsFactoryProvider
		Implements IBarActionItemsFactoryProvider
        Public Function CreateBarActionItemsFactory(ByVal barManager As BarManager) As BarActionItemsFactory Implements IBarActionItemsFactoryProvider.CreateBarActionItemsFactory
            Return New MyBarActionItemsFactory(barManager)
        End Function
	End Class
End Namespace
