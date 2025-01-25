Imports DevExpress.XtraEditors

Namespace WinForms.Client

    Public Partial Class EditForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private bsDataItem As BindingSource = New BindingSource()

        Public Sub SetEditableData(ByVal item As OData.Server.BusinessObjects.OrderItem)
            bsDataItem.DataSource = DTO.Create(item)
            dataLayoutControl1.DataSource = bsDataItem
        End Sub

        Public Sub ApplyChanges(ByVal item As OData.Server.BusinessObjects.OrderItem)
            Dim dto = CType(bsDataItem.DataSource, DTO)
            dto.ApplyChanges(item)
        End Sub

        Private Sub Cancel_button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.Cancel
        End Sub

        Private Sub OK_button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace
