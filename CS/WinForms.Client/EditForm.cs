
using DevExpress.XtraEditors;

namespace WinForms.Client {
    public partial class EditForm : XtraForm {
        public EditForm() {
            InitializeComponent();
        }
        BindingSource bsDataItem = new BindingSource();
        public void SetEditableData(OData.Server.BusinessObjects.OrderItem item) {
            bsDataItem.DataSource = DTO.Create(item);
            dataLayoutControl1.DataSource = bsDataItem;
        }
        public void ApplyChanges(OData.Server.BusinessObjects.OrderItem item) {
            var dto = (DTO)bsDataItem.DataSource;
            dto.ApplyChanges(item);
        }
        void Cancel_button_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
        void OK_button_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }
    }
}
