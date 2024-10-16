using System.Diagnostics;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace WinForms.Client {
    public partial class MainForm : XtraForm {
        Default.Container dataContext;
        public MainForm() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            this.oDataInstantFeedbackSource1.GetSource += oDataInstantFeedbackSource1_GetSource;
            // This line of code is generated by Data Source Configuration Wizard
            this.oDataInstantFeedbackSource1.DismissSource += oDataInstantFeedbackSource1_DismissSource;

            GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Count", "Count={0}");
            this.colOrderDate.Summary.Add(item1);
            gridView1.PopupMenuShowing += GridView1_PopupMenuShowing;
        }

        private void GridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
            if(e.Menu != null) {
                foreach(DXMenuItem d in e.Menu.Items) {
                    if(d.Caption.StartsWith("Filter")) // Disable Filter Editor
                        d.Enabled = false;
                }
            }
        }
        async void GridView1_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e) {
            e.Allow = false;
            var row = gridView1.GetRow(e.RowHandle) as DevExpress.Data.Async.Helpers.ReadonlyThreadSafeProxyForObjectFromAnotherThread;
            if(row != null) {
                var dataObject = row.OriginalRow as OData.Server.BusinessObjects.OrderItem;
                if(dataObject != null) {
                    bool canEdit = await ClientSecurity.EnsureEditPermissions(dataObject.GetType().FullName, dataObject.ID.ToString());
                    if(!canEdit) {
                        XtraMessageBox.Show("You can't edit this object due to security reasons");
                        return;
                    }

                    using(var editForm = new EditForm()) {
                        editForm.SetEditableData(dataObject);
                        if(editForm.ShowDialog() == DialogResult.OK) {
                            var contextObj = this.dataContext.OrderItem.Where(n => n.ID == dataObject.ID).SingleOrDefault();
                            editForm.ApplyChanges(contextObj);
                            this.dataContext.UpdateObject(contextObj);
                            this.dataContext.SaveChanges();
                            gridView1.RefreshData();
                        }
                    }
                }
            }
        }
        // This event is generated by Data Source Configuration Wizard
        void oDataInstantFeedbackSource1_GetSource(object sender, DevExpress.Data.ODataLinq.GetSourceEventArgs e) {
            // Instantiate a new DataContext            
            this.dataContext = new Default.Container(new System.Uri(ClientSecurity.ODataUrl));
            dataContext.BuildingRequest += DataContext_BuildingRequest;
            dataContext.ReceivingResponse += DataContext_ReceivingResponse;
            // Assign a query to the ODataInstantFeedbackSource
            e.Query = dataContext.OrderItem;
            // Assign the DataContext to the Tag property,
            // to dismiss it in the DismissSource event handler
            e.Tag = dataContext;
        }
        // This event is generated by Data Source Configuration Wizard
        void oDataInstantFeedbackSource1_DismissSource(object sender, DevExpress.Data.ODataLinq.GetSourceEventArgs e) {
            // Here you can dismiss the objects you have assigned to the GetSourceEventArgs.Tag and GetSourceEventArgs.Query properties in the GetSource event handler.
            Default.Container dataContext = ((Default.Container)e.Tag);
        }
        //
        void DataContext_ReceivingResponse(object sender, Microsoft.OData.Client.ReceivingResponseEventArgs e) {
            Debug.WriteLine("HTTP:" + e.ResponseMessage.StatusCode);
            if(e.ResponseMessage.StatusCode != 200) {
                // HTTP errors processing
            }
        }
        void DataContext_BuildingRequest(object sender, Microsoft.OData.Client.BuildingRequestEventArgs e) {
            ClientSecurity.EnsureAuthorization(e);
            Debug.WriteLine("URL:" + e.RequestUri);
        }
    }
}
