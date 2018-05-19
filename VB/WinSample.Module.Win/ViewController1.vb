Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Data.Filtering

Namespace WinSample.Module.Win
	Partial Public Class ViewController1
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewId = "BO1_ListView"
		End Sub
		Protected Overrides Overloads Sub OnActivated()
			MyBase.OnActivated()
			simpleAction1.Checked = False
		End Sub
		Private Const filterValue As String = "Not IsNull([Property1])"
		Private Const filterName As String = "ListViewFilter"
		Private Sub simpleAction1_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction1.Execute
			If simpleAction1.Checked Then
				CType(View, ListView).CollectionSource.Criteria(filterName) = CriteriaOperator.Parse(filterValue)
			Else
				CType(View, ListView).CollectionSource.Criteria.Remove(filterName)
			End If
		End Sub
	End Class
End Namespace
