﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace AdvancedSupportForEnums
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			DevExpress.Xpo.XpoDefault.DataLayer = New DevExpress.Xpo.SimpleDataLayer(New DevExpress.Xpo.DB.InMemoryDataStore())
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
