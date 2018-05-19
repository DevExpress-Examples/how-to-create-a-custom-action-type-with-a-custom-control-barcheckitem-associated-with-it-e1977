Imports Microsoft.VisualBasic
Imports System
Namespace WinSample.Module.Win
	Partial Public Class ViewController1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.simpleAction1 = New WinSample.Module.Win.CheckableSimpleAction(Me.components)
			' 
			' simpleAction1
			' 
			Me.simpleAction1.Caption = "Filter"
			Me.simpleAction1.Checked = False
			Me.simpleAction1.Id = "601213b0-c5b4-4136-95a2-eea9b2d6e498"
			Me.simpleAction1.Tag = Nothing
			Me.simpleAction1.TypeOfView = Nothing
'			Me.simpleAction1.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction1_Execute);

		End Sub

		#End Region

		Private WithEvents simpleAction1 As CheckableSimpleAction
	End Class
End Namespace
