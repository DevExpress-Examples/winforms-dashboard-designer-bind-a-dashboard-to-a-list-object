Imports System
Imports System.Collections.Generic
Imports System.Threading

Namespace Dashboard_BindingToList

    Public Class Data

        Public Property SalesPerson As String

        Public Property Quantity As Integer

        Public Shared Function CreateData() As List(Of Data)
            Dim data As List(Of Data) = New List(Of Data)()
            Dim salesPersons As String() = {"Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio", "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling"}
            For i As Integer = 0 To 100 - 1
                Dim record As Data = New Data()
                Dim seed As Integer = CInt(Date.Now.Ticks) And &H0000FFFF
                record.SalesPerson = salesPersons(New Random(seed).Next(0, salesPersons.Length))
                record.Quantity = New Random(seed).Next(0, 100)
                data.Add(record)
                Thread.Sleep(3)
            Next

            Return data
        End Function
    End Class
End Namespace
