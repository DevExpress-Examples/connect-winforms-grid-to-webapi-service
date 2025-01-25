Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Xml.Serialization
Imports DevExpress.Persistent.BaseImpl.EF

Namespace OData.Server.BusinessObjects

    Public Class OrderItem
        Inherits BaseObject

        Public Overridable Property ProductName As String

        Public Overridable Property UnitPrice As Decimal

        Public Overridable Property Quantity As Integer

        Public Overridable Property Discount As Single

        Public Overridable Property OrderDate As DateTime

        Public Shared Function GetInitialData() As List(Of OrderItem)
            Dim assembly = Assembly.GetExecutingAssembly()
            Dim resourceName = assembly.GetManifestResourceNames().[Single](Function(str) str.EndsWith("order_items.xml"))
            Dim xsSubmit As XmlSerializer = New XmlSerializer(GetType(List(Of OrderItem)))
            Using stream As Stream = assembly.GetManifestResourceStream(resourceName)
                Return CType(xsSubmit.Deserialize(stream), List(Of OrderItem))
            End Using
        End Function
    End Class
End Namespace
