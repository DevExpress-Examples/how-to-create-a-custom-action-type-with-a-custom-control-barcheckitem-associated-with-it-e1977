Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.Templates

Namespace Solution5.Module.Win
	<ToolboxItemFilter("Xaf.Platform.Win")> _
	Public NotInheritable Partial Class Solution5WindowsFormsModule
		Inherits ModuleBase
		Public Sub New()
			InitializeComponent()
			BarActionItemsFactoryProvider.Instance = New MyBarActionItemsFactoryProvider()
		End Sub
	End Class
End Namespace
