Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Actions
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base

Namespace Solution5.Module
	Public Class CheckableSimpleAction
		Inherits SimpleAction
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub
		Public Sub New(ByVal owner As Controller, ByVal id As String, ByVal category As PredefinedCategory)
			MyBase.New(owner, id, category)
		End Sub

		Private _Checked As Boolean = False
		Public Property Checked() As Boolean
			Get
				Return _Checked
			End Get
			Set(ByVal value As Boolean)
				If _Checked <> value Then
					_Checked = value
					DoCheckedStateChanged()
					If Enabled.ResultValue AndAlso Active.ResultValue Then
						DoExecute()
					End If
				End If
			End Set
		End Property

		Private Sub DoCheckedStateChanged()
			RaiseEvent CheckedStateChanged(Me, New EventArgs())
		End Sub

		Public Event CheckedStateChanged As EventHandler
	End Class
End Namespace