Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors

Namespace WinForms.Client

    Friend Module Program

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call WindowsFormsSettings.SetPerMonitorDpiAware()
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(SkinStyle.WXI)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            '
            Call Initialize()
            Using authForm As AuthForm = New AuthForm()
                If authForm.ShowDialog() Is DialogResult.OK Then
                    ClientSecurity.SetAuthToken(authForm.Token)
                    Application.Run(New MainForm())
                End If
            End Using
        End Sub
    End Module
End Namespace
