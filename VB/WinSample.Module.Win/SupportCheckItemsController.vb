Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Win.Templates
Imports DevExpress.XtraBars
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers.Items

Namespace WinSample.Module.Win
	Partial Public Class SupportCheckItemsController
		Inherits WindowController
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			AddHandler DefaultBarActionItemsFactory.CustomizeActionControl, AddressOf DefaultBarActionItemsFactory_CustomizeActionControl
		End Sub
		Private Sub DefaultBarActionItemsFactory_CustomizeActionControl(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.Win.Templates.ActionContainers.CustomizeActionControlEventArgs(Of ActionBase))
			If TypeOf e.Action Is CheckableSimpleAction Then
				e.ActionControl = New CheckActionItem(e.Action, e.ActionControl.Control.Manager)
			End If
		End Sub
	End Class
End Namespace
