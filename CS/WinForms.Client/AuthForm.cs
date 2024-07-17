using DevExpress.XtraEditors;

namespace WinForms.Client {
    public partial class AuthForm : XtraForm {
        public AuthForm() {
            InitializeComponent();
        }
        public string Token {
            get;
            private set;
        }
        async void Login_Click(object sender, EventArgs e) {
            string authToken = await ClientSecurity.Authenticate(userNameEdit.Text, passwordEdit.Text);
            if(authToken == null) {
                XtraMessageBox.Show("Problem with authentificate");
                DialogResult = DialogResult.Cancel;
            }
            else {
                Token = authToken;
                DialogResult = DialogResult.OK;
            }
        }
        void Cancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
