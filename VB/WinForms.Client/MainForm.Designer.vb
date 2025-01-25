Namespace WinForms.Client

    Partial Class MainForm

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.oDataInstantFeedbackSource1 = New DevExpress.Data.ODataLinq.ODataInstantFeedbackSource()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            Me.MainFormlayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.gridControl1item = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.MainFormlayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MainFormlayoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1item), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.oDataInstantFeedbackSource1
            Me.gridControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(776, 426)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' oDataInstantFeedbackSource1
            ' 
            Me.oDataInstantFeedbackSource1.DefaultSorting = "ID ASC"
            Me.oDataInstantFeedbackSource1.DesignTimeElementType = GetType(OData.Server.BusinessObjects.OrderItem)
            Me.oDataInstantFeedbackSource1.KeyExpressions = New String() {"ID"}
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colProductName, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colOrderDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            Me.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = False
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.EditFormShowing += New DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(AddressOf Me.GridView1_EditFormShowing)
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 3
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 4
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.DisplayFormat.FormatString = "MM/dd/yyyy"
            Me.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 5
            ' 
            ' MainFormlayoutControl1ConvertedLayout
            ' 
            Me.MainFormlayoutControl1ConvertedLayout.Controls.Add(Me.gridControl1)
            Me.MainFormlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainFormlayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.MainFormlayoutControl1ConvertedLayout.Name = "MainFormlayoutControl1ConvertedLayout"
            Me.MainFormlayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.MainFormlayoutControl1ConvertedLayout.Size = New System.Drawing.Size(800, 450)
            Me.MainFormlayoutControl1ConvertedLayout.TabIndex = 1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.gridControl1item})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(800, 450)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' gridControl1item
            ' 
            Me.gridControl1item.Control = Me.gridControl1
            Me.gridControl1item.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1item.Name = "gridControl1item"
            Me.gridControl1item.Size = New System.Drawing.Size(780, 430)
            Me.gridControl1item.TextSize = New System.Drawing.Size(0, 0)
            Me.gridControl1item.TextVisible = False
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.MainFormlayoutControl1ConvertedLayout)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.MainFormlayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.MainFormlayoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1item), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private oDataInstantFeedbackSource1 As DevExpress.Data.ODataLinq.ODataInstantFeedbackSource

        Private colID As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private MainFormlayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gridControl1item As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
