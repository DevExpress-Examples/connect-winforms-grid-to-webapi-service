Namespace WinForms.Client

    Partial Class EditForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
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
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.dataLayoutControl2 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ProductNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.orderItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.UnitPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.QuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.DiscountTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.OrderDateDateTimeOffsetEdit = New DevExpress.XtraEditors.DateEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForProductName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForUnitPrice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForQuantity = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForDiscount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForOrderDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.OK_button = New DevExpress.XtraEditors.SimpleButton()
            Me.Cancel_button = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType((Me.dataLayoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ProductNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.orderItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.UnitPriceTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.QuantityTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.DiscountTextEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.OrderDateDateTimeOffsetEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.OrderDateDateTimeOffsetEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForProductName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForUnitPrice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForQuantity), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForDiscount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForOrderDate), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.Controls.Add(Me.dataLayoutControl2)
            Me.dataLayoutControl1.Controls.Add(Me.ProductNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.UnitPriceTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.QuantityTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DiscountTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.OrderDateDateTimeOffsetEdit)
            Me.dataLayoutControl1.DataMember = Nothing
            Me.dataLayoutControl1.DataSource = Me.orderItemBindingSource
            Me.dataLayoutControl1.Location = New System.Drawing.Point(12, 12)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-3249, -310, 650, 400)
            Me.dataLayoutControl1.Root = Me.Root
            Me.dataLayoutControl1.Size = New System.Drawing.Size(375, 265)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' dataLayoutControl2
            ' 
            Me.dataLayoutControl2.Location = New System.Drawing.Point(12, 132)
            Me.dataLayoutControl2.Name = "dataLayoutControl2"
            Me.dataLayoutControl2.Root = Me.layoutControlGroup2
            Me.dataLayoutControl2.Size = New System.Drawing.Size(351, 121)
            Me.dataLayoutControl2.TabIndex = 10
            Me.dataLayoutControl2.Text = "dataLayoutControl2"
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(351, 121)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' ProductNameTextEdit
            ' 
            Me.ProductNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderItemBindingSource, "ProductName", True))
            Me.ProductNameTextEdit.Location = New System.Drawing.Point(91, 12)
            Me.ProductNameTextEdit.Name = "ProductNameTextEdit"
            Me.ProductNameTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.ProductNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.ProductNameTextEdit.TabIndex = 5
            ' 
            ' orderItemBindingSource
            ' 
            Me.orderItemBindingSource.DataSource = GetType(OData.Server.BusinessObjects.OrderItem)
            ' 
            ' UnitPriceTextEdit
            ' 
            Me.UnitPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderItemBindingSource, "UnitPrice", True))
            Me.UnitPriceTextEdit.Location = New System.Drawing.Point(91, 36)
            Me.UnitPriceTextEdit.Name = "UnitPriceTextEdit"
            Me.UnitPriceTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.UnitPriceTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.UnitPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.UnitPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.UnitPriceTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.UnitPriceTextEdit.Properties.MaskSettings.[Set]("mask", "G")
            Me.UnitPriceTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.UnitPriceTextEdit.StyleController = Me.dataLayoutControl1
            Me.UnitPriceTextEdit.TabIndex = 6
            ' 
            ' QuantityTextEdit
            ' 
            Me.QuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderItemBindingSource, "Quantity", True))
            Me.QuantityTextEdit.Location = New System.Drawing.Point(91, 60)
            Me.QuantityTextEdit.Name = "QuantityTextEdit"
            Me.QuantityTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.QuantityTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.QuantityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.QuantityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.QuantityTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.QuantityTextEdit.Properties.MaskSettings.[Set]("mask", "N0")
            Me.QuantityTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.QuantityTextEdit.StyleController = Me.dataLayoutControl1
            Me.QuantityTextEdit.TabIndex = 7
            ' 
            ' DiscountTextEdit
            ' 
            Me.DiscountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderItemBindingSource, "Discount", True))
            Me.DiscountTextEdit.Location = New System.Drawing.Point(91, 84)
            Me.DiscountTextEdit.Name = "DiscountTextEdit"
            Me.DiscountTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.DiscountTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.DiscountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.DiscountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.DiscountTextEdit.Properties.MaskSettings.[Set]("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.DiscountTextEdit.Properties.MaskSettings.[Set]("mask", "F")
            Me.DiscountTextEdit.Size = New System.Drawing.Size(272, 20)
            Me.DiscountTextEdit.StyleController = Me.dataLayoutControl1
            Me.DiscountTextEdit.TabIndex = 8
            ' 
            ' OrderDateDateTimeOffsetEdit
            ' 
            Me.OrderDateDateTimeOffsetEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.orderItemBindingSource, "OrderDate", True))
            Me.OrderDateDateTimeOffsetEdit.EditValue = Nothing
            Me.OrderDateDateTimeOffsetEdit.Location = New System.Drawing.Point(91, 108)
            Me.OrderDateDateTimeOffsetEdit.Name = "OrderDateDateTimeOffsetEdit"
            Me.OrderDateDateTimeOffsetEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.OrderDateDateTimeOffsetEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.OrderDateDateTimeOffsetEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.OrderDateDateTimeOffsetEdit.Size = New System.Drawing.Size(272, 20)
            Me.OrderDateDateTimeOffsetEdit.StyleController = Me.dataLayoutControl1
            Me.OrderDateDateTimeOffsetEdit.TabIndex = 9
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(375, 265)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForProductName, Me.ItemForUnitPrice, Me.ItemForQuantity, Me.ItemForDiscount, Me.ItemForOrderDate})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(355, 120)
            ' 
            ' ItemForProductName
            ' 
            Me.ItemForProductName.Control = Me.ProductNameTextEdit
            Me.ItemForProductName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForProductName.Name = "ItemForProductName"
            Me.ItemForProductName.Size = New System.Drawing.Size(355, 24)
            Me.ItemForProductName.Text = "Product Name"
            Me.ItemForProductName.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' ItemForUnitPrice
            ' 
            Me.ItemForUnitPrice.Control = Me.UnitPriceTextEdit
            Me.ItemForUnitPrice.Location = New System.Drawing.Point(0, 24)
            Me.ItemForUnitPrice.Name = "ItemForUnitPrice"
            Me.ItemForUnitPrice.Size = New System.Drawing.Size(355, 24)
            Me.ItemForUnitPrice.Text = "Unit Price"
            Me.ItemForUnitPrice.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' ItemForQuantity
            ' 
            Me.ItemForQuantity.Control = Me.QuantityTextEdit
            Me.ItemForQuantity.Location = New System.Drawing.Point(0, 48)
            Me.ItemForQuantity.Name = "ItemForQuantity"
            Me.ItemForQuantity.Size = New System.Drawing.Size(355, 24)
            Me.ItemForQuantity.Text = "Quantity"
            Me.ItemForQuantity.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' ItemForDiscount
            ' 
            Me.ItemForDiscount.Control = Me.DiscountTextEdit
            Me.ItemForDiscount.Location = New System.Drawing.Point(0, 72)
            Me.ItemForDiscount.Name = "ItemForDiscount"
            Me.ItemForDiscount.Size = New System.Drawing.Size(355, 24)
            Me.ItemForDiscount.Text = "Discount"
            Me.ItemForDiscount.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' ItemForOrderDate
            ' 
            Me.ItemForOrderDate.Control = Me.OrderDateDateTimeOffsetEdit
            Me.ItemForOrderDate.Location = New System.Drawing.Point(0, 96)
            Me.ItemForOrderDate.Name = "ItemForOrderDate"
            Me.ItemForOrderDate.Size = New System.Drawing.Size(355, 24)
            Me.ItemForOrderDate.Text = "Order Date"
            Me.ItemForOrderDate.TextSize = New System.Drawing.Size(67, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.dataLayoutControl2
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(355, 125)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' OK_button
            ' 
            Me.OK_button.Location = New System.Drawing.Point(73, 284)
            Me.OK_button.Name = "OK_button"
            Me.OK_button.Size = New System.Drawing.Size(75, 23)
            Me.OK_button.TabIndex = 1
            Me.OK_button.Text = "OK"
            Me.OK_button.Click += New System.EventHandler(AddressOf Me.OK_button_Click)
            ' 
            ' Cancel_button
            ' 
            Me.Cancel_button.Location = New System.Drawing.Point(254, 284)
            Me.Cancel_button.Name = "Cancel_button"
            Me.Cancel_button.Size = New System.Drawing.Size(75, 23)
            Me.Cancel_button.TabIndex = 2
            Me.Cancel_button.Text = "Cancel"
            Me.Cancel_button.Click += New System.EventHandler(AddressOf Me.Cancel_button_Click)
            ' 
            ' EditForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(410, 330)
            Me.Controls.Add(Me.Cancel_button)
            Me.Controls.Add(Me.OK_button)
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Name = "EditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "EditForm"
            CType((Me.dataLayoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType((Me.dataLayoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ProductNameTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.orderItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.UnitPriceTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.QuantityTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.DiscountTextEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.OrderDateDateTimeOffsetEdit.Properties.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.OrderDateDateTimeOffsetEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForProductName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForUnitPrice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForQuantity), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForDiscount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForOrderDate), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private orderItemBindingSource As System.Windows.Forms.BindingSource

        Private ProductNameTextEdit As DevExpress.XtraEditors.TextEdit

        Private UnitPriceTextEdit As DevExpress.XtraEditors.TextEdit

        Private QuantityTextEdit As DevExpress.XtraEditors.TextEdit

        Private DiscountTextEdit As DevExpress.XtraEditors.TextEdit

        Private OrderDateDateTimeOffsetEdit As DevExpress.XtraEditors.DateEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForProductName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForUnitPrice As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForQuantity As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForDiscount As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForOrderDate As DevExpress.XtraLayout.LayoutControlItem

        Private OK_button As DevExpress.XtraEditors.SimpleButton

        Private Cancel_button As DevExpress.XtraEditors.SimpleButton

        Private dataLayoutControl2 As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
