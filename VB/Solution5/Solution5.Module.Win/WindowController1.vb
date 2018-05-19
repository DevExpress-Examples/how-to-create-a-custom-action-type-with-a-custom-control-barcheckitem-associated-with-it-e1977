Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base

Namespace Solution5.Module.Win
	Public Class WindowController1
		Inherits WindowController
		Public Sub New()
			Dim action As New CheckableSimpleAction(Me, "TestAction", PredefinedCategory.RecordEdit)
		End Sub
	End Class


End Namespace
