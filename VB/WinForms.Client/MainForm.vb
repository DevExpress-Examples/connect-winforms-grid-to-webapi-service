Imports System.Diagnostics
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Namespace WinForms.Client

    Public Partial Class MainForm
        Inherits XtraForm

        Private dataContext As [Default].Container

        Public Sub New()
            InitializeComponent()
            ' This line of code is generated by Data Source Configuration Wizard
            Me.oDataInstantFeedbackSource1.GetSource += AddressOf oDataInstantFeedbackSource1_GetSource
            ' This line of code is generated by Data Source Configuration Wizard
            Me.oDataInstantFeedbackSource1.DismissSource += AddressOf oDataInstantFeedbackSource1_DismissSource
            Dim item1 As GridColumnSummaryItem = New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Count", "Count={0}")
            colOrderDate.Summary.Add(item1)
            Me.gridView1.PopupMenuShowing += AddressOf GridView1_PopupMenuShowing
        End Sub

        Private Sub GridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As Views.Grid.PopupMenuShowingEventArgs)
            If e.Menu IsNot Nothing Then
                For Each d As DXMenuItem In e.Menu.Items
                    If d.Caption.StartsWith("Filter") Then d.Enabled = False ' Disable Filter Editor
                Next
            End If
        End Sub

        Private Async Sub GridView1_EditFormShowing(ByVal sender As Object, ByVal e As Views.Grid.EditFormShowingEventArgs)
            e.Allow = False
            Dim row = TryCast(gridView1.GetRow(e.RowHandle), DevExpress.Data.Async.Helpers.ReadonlyThreadSafeProxyForObjectFromAnotherThread)
            If row IsNot Nothing Then
                Dim dataObject = TryCast(row.OriginalRow, OData.Server.BusinessObjects.OrderItem)
                If dataObject IsNot Nothing Then
                    Dim canEdit As Boolean = Await ClientSecurity.EnsureEditPermissions(dataObject.[GetType]().FullName, dataObject.ID.ToString())
                    If Not canEdit Then
                        XtraMessageBox.Show("You can't edit this object due to security reasons")
                        Return
                    End If

                    Using editForm = New EditForm()
                        editForm.SetEditableData(dataObject)
                        If editForm.ShowDialog() Is DialogResult.OK Then
                            Dim contextObj = dataContext.OrderItem.Where(Function(n) n.ID Is dataObject.ID).SingleOrDefault()
                            editForm.ApplyChanges(contextObj)
                            dataContext.UpdateObject(contextObj)
                            dataContext.SaveChanges()
                            gridView1.RefreshData()
                        End If
                    End Using
                End If
            End If
        End Sub

        ' This event is generated by Data Source Configuration Wizard
        Private Sub oDataInstantFeedbackSource1_GetSource(ByVal sender As Object, ByVal e As DevExpress.Data.ODataLinq.GetSourceEventArgs)
            ' Instantiate a new DataContext            
            dataContext = New [Default].Container(New System.Uri(ODataUrl))
            Me.dataContext.BuildingRequest += AddressOf DataContext_BuildingRequest
            Me.dataContext.ReceivingResponse += AddressOf DataContext_ReceivingResponse
            ' Assign a query to the ODataInstantFeedbackSource
            e.Query = dataContext.OrderItem
            ' Assign the DataContext to the Tag property,
            ' to dismiss it in the DismissSource event handler
            e.Tag = dataContext
        End Sub

        ' This event is generated by Data Source Configuration Wizard
        Private Sub oDataInstantFeedbackSource1_DismissSource(ByVal sender As Object, ByVal e As DevExpress.Data.ODataLinq.GetSourceEventArgs)
            ' Here you can dismiss the objects you have assigned to the GetSourceEventArgs.Tag and GetSourceEventArgs.Query properties in the GetSource event handler.
            Dim dataContext As [Default].Container = CType(e.Tag, [Default].Container)
        End Sub

        '
        Private Sub DataContext_ReceivingResponse(ByVal sender As Object, ByVal e As Microsoft.OData.Client.ReceivingResponseEventArgs)
            Debug.WriteLine("HTTP:" & e.ResponseMessage.StatusCode)
            If e.ResponseMessage.StatusCode IsNot 200 Then
            ' HTTP errors processing
            End If
        End Sub

        Private Sub DataContext_BuildingRequest(ByVal sender As Object, ByVal e As Microsoft.OData.Client.BuildingRequestEventArgs)
            EnsureAuthorization(e)
            Debug.WriteLine("URL:" & e.RequestUri)
        End Sub
    End Class
End Namespace
