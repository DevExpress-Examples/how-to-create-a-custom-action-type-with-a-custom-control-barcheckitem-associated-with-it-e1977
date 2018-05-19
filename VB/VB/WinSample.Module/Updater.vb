Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace WinSample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If New XPCollection(Of BO1)(Session).Count = 0 Then
				Dim bo1 As New BO1(Session)
				bo1.Save()
				bo1 = New BO1(Session)
				bo1.Property1 = "test"
				bo1.Save()
			End If
		End Sub
	End Class
End Namespace
