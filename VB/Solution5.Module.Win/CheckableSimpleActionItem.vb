Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers.Items
Imports DevExpress.XtraBars

Namespace Solution5.Module.Win
	Public Class CheckableSimpleActionItem
		Inherits BarActionBaseItem
		Public Sub New(ByVal action As ActionBase, ByVal manager As BarManager)
			MyBase.New(action, manager)
		End Sub

		Protected Overrides Sub ItemClicked()
			MyBase.ItemClicked()
			If IsItemClickEnable AndAlso IsConfirmed() Then
				Action.Checked = Not Action.Checked
			End If
		End Sub

		Protected Overrides Function CreateControlCore() As BarItem
			Return New BarCheckItem()
		End Function

		Public Sub Execute()
			ItemClicked()
		End Sub

		Protected Overrides Sub SynchronizeWithActionCore()
			MyBase.SynchronizeWithActionCore()
			Control.Checked = Action.Checked
			AddHandler Action.CheckedStateChanged, AddressOf Action_CheckedStateChanged
		End Sub

		Private Sub Action_CheckedStateChanged(ByVal sender As Object, ByVal e As EventArgs)
			Control.Checked = Action.Checked
		End Sub

		Public Shadows ReadOnly Property Control() As BarCheckItem
			Get
				Return CType(MyBase.Control, BarCheckItem)
			End Get
		End Property
		Public Shadows ReadOnly Property Action() As CheckableSimpleAction
			Get
				Return CType(MyBase.Action, CheckableSimpleAction)
			End Get
		End Property
	End Class
End Namespace