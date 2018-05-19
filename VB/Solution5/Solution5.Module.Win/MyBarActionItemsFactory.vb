﻿Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Win.Templates
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers.Items
Imports DevExpress.XtraBars

Namespace Solution5.Module.Win
	Public Class MyBarActionItemsFactory
		Inherits BarActionItemsFactory
		Public Sub New(ByVal manager As BarManager)
			MyBase.New(manager)
		End Sub
		Protected Overrides Function CreateActionItem(ByVal action As ActionBase) As BarActionBaseItem
			If TypeOf action Is CheckableSimpleAction Then
				Return New CheckableSimpleActionItem(action, Manager)
			End If
			Return MyBase.CreateActionItem(action)
		End Function
	End Class
End Namespace
