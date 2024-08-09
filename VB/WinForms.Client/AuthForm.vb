Imports DevExpress.XtraEditors

Namespace WinForms.Client

    Public Partial Class AuthForm
        Inherits XtraForm

        Private _Token As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property Token As String
            Get
                Return _Token
            End Get

            Private Set(ByVal value As String)
                _Token = value
            End Set
        End Property

        Private Async Sub Login_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim authToken As String = Await ClientSecurity.Authenticate(userNameEdit.Text, passwordEdit.Text)
             ''' Cannot convert IfStatementSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.MethodBodyExecutableStatementVisitor.VisitIfStatement(IfStatementSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
''' 
''' Input:
'''             if(authToken == null) {
'''                 DevExpress.XtraEditors.XtraMessageBox.Show("Problem with authentificate");
'''                 DialogResult = DialogResult.Cancel;
'''             }
'''             else {
'''                 this.Token = authToken;
'''                 DialogResult = DialogResult.OK;
'''             }
''' 
'''  End Sub

        Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Application.[Exit]()
        End Sub
    End Class
End Namespace
