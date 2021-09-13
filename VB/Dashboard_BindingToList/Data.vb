Imports System
Imports System.Collections.Generic
Imports System.Threading

Namespace Dashboard_BindingToList
	Public Class Data
		Public Property SalesPerson() As String
		Public Property Quantity() As Integer

		Public Shared Function CreateData() As List(Of Data)
'INSTANT VB NOTE: The variable data was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim data_Conflict As New List(Of Data)()
			Dim salesPersons() As String = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio", "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" }

			For i As Integer = 0 To 99
				Dim record As New Data()
				Dim seed As Integer = CInt(DateTime.Now.Ticks) And &HFFFF
				record.SalesPerson = salesPersons((New Random(seed)).Next(0, salesPersons.Length))
				record.Quantity = (New Random(seed)).Next(0, 100)
				data_Conflict.Add(record)
				Thread.Sleep(3)
			Next i
			Return data_Conflict
		End Function
	End Class
End Namespace
