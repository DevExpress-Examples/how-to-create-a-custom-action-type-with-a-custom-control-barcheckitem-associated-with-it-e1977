Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinSample.Module
	<DefaultClassOptions> _
	Public Class BO1
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _Property1 As String
		Public Property Property1() As String
			Get
				Return _Property1
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property1", _Property1, value)
			End Set
		End Property
	End Class
End Namespace
