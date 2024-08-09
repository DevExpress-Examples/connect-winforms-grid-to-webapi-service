Namespace WinForms.Client

    Public Class DTO

        Public Property ID As Guid

        Public Property ProductName As String

        Public Property UnitPrice As Decimal

        Public Property Quantity As Integer

        Public Property Discount As Single

        Public Property OrderDate As DateTime

        '
        Public Shared Function Create(ByVal item As OData.Server.BusinessObjects.OrderItem) As DTO
            Return New DTO() With {item.ID, item.ProductName, item.UnitPrice, item.Quantity, item.Discount, .OrderDate = item.OrderDate.[Date]}
        End Function

        Public Sub ApplyChanges(ByVal item As OData.Server.BusinessObjects.OrderItem)
            item.ID = ID
            item.OrderDate = OrderDate
            item.Quantity = Quantity
            item.Discount = Discount
            item.UnitPrice = UnitPrice
            item.ProductName = ProductName
        End Sub
    End Class
End Namespace
