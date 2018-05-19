Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace WinSample.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			If ObjectSpace.GetObjectsCount(GetType(BO1), Nothing) = 0 Then
				Dim bo1 As BO1 = ObjectSpace.CreateObject(Of BO1)()
				bo1.Save()
				bo1 = ObjectSpace.CreateObject(Of BO1)()
				bo1.Property1 = "test"
				bo1.Save()
			End If
		End Sub
	End Class
End Namespace
