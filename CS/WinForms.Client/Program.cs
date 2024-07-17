using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace WinForms.Client {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.SetPerMonitorDpiAware();
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.WXI);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //
            ClientSecurity.Initialize();
            using(AuthForm authForm = new AuthForm()) {
                if(authForm.ShowDialog() == DialogResult.OK) {
                    ClientSecurity.SetAuthToken(authForm.Token);
                    Application.Run(new MainForm());
                }
            }
        }
    }
}