namespace WinForms.Client {
    partial class EditForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.QuantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DiscountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OrderDateDateTimeOffsetEdit = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnitPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuantity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDiscount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOrderDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.OK_button = new DevExpress.XtraEditors.SimpleButton();
            this.Cancel_button = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateTimeOffsetEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateTimeOffsetEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dataLayoutControl2);
            this.dataLayoutControl1.Controls.Add(this.ProductNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UnitPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.QuantityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DiscountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OrderDateDateTimeOffsetEdit);
            this.dataLayoutControl1.DataMember = null;
            this.dataLayoutControl1.DataSource = this.orderItemBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-3249, -310, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(375, 265);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Location = new System.Drawing.Point(12, 132);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.layoutControlGroup2;
            this.dataLayoutControl2.Size = new System.Drawing.Size(351, 121);
            this.dataLayoutControl2.TabIndex = 10;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(351, 121);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderItemBindingSource, "ProductName", true));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(91, 12);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(272, 20);
            this.ProductNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ProductNameTextEdit.TabIndex = 5;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OData.Server.BusinessObjects.OrderItem);
            // 
            // UnitPriceTextEdit
            // 
            this.UnitPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderItemBindingSource, "UnitPrice", true));
            this.UnitPriceTextEdit.Location = new System.Drawing.Point(91, 36);
            this.UnitPriceTextEdit.Name = "UnitPriceTextEdit";
            this.UnitPriceTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.UnitPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.UnitPriceTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.UnitPriceTextEdit.Properties.MaskSettings.Set("mask", "G");
            this.UnitPriceTextEdit.Size = new System.Drawing.Size(272, 20);
            this.UnitPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.UnitPriceTextEdit.TabIndex = 6;
            // 
            // QuantityTextEdit
            // 
            this.QuantityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderItemBindingSource, "Quantity", true));
            this.QuantityTextEdit.Location = new System.Drawing.Point(91, 60);
            this.QuantityTextEdit.Name = "QuantityTextEdit";
            this.QuantityTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.QuantityTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QuantityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QuantityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QuantityTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.QuantityTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.QuantityTextEdit.Size = new System.Drawing.Size(272, 20);
            this.QuantityTextEdit.StyleController = this.dataLayoutControl1;
            this.QuantityTextEdit.TabIndex = 7;
            // 
            // DiscountTextEdit
            // 
            this.DiscountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderItemBindingSource, "Discount", true));
            this.DiscountTextEdit.Location = new System.Drawing.Point(91, 84);
            this.DiscountTextEdit.Name = "DiscountTextEdit";
            this.DiscountTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.DiscountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.DiscountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DiscountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DiscountTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.DiscountTextEdit.Properties.MaskSettings.Set("mask", "F");
            this.DiscountTextEdit.Size = new System.Drawing.Size(272, 20);
            this.DiscountTextEdit.StyleController = this.dataLayoutControl1;
            this.DiscountTextEdit.TabIndex = 8;
            // 
            // OrderDateDateTimeOffsetEdit
            // 
            this.OrderDateDateTimeOffsetEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderItemBindingSource, "OrderDate", true));
            this.OrderDateDateTimeOffsetEdit.EditValue = null;
            this.OrderDateDateTimeOffsetEdit.Location = new System.Drawing.Point(91, 108);
            this.OrderDateDateTimeOffsetEdit.Name = "OrderDateDateTimeOffsetEdit";
            this.OrderDateDateTimeOffsetEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.OrderDateDateTimeOffsetEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OrderDateDateTimeOffsetEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OrderDateDateTimeOffsetEdit.Size = new System.Drawing.Size(272, 20);
            this.OrderDateDateTimeOffsetEdit.StyleController = this.dataLayoutControl1;
            this.OrderDateDateTimeOffsetEdit.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(375, 265);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProductName,
            this.ItemForUnitPrice,
            this.ItemForQuantity,
            this.ItemForDiscount,
            this.ItemForOrderDate});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(355, 120);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(355, 24);
            this.ItemForProductName.Text = "Product Name";
            this.ItemForProductName.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForUnitPrice
            // 
            this.ItemForUnitPrice.Control = this.UnitPriceTextEdit;
            this.ItemForUnitPrice.Location = new System.Drawing.Point(0, 24);
            this.ItemForUnitPrice.Name = "ItemForUnitPrice";
            this.ItemForUnitPrice.Size = new System.Drawing.Size(355, 24);
            this.ItemForUnitPrice.Text = "Unit Price";
            this.ItemForUnitPrice.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForQuantity
            // 
            this.ItemForQuantity.Control = this.QuantityTextEdit;
            this.ItemForQuantity.Location = new System.Drawing.Point(0, 48);
            this.ItemForQuantity.Name = "ItemForQuantity";
            this.ItemForQuantity.Size = new System.Drawing.Size(355, 24);
            this.ItemForQuantity.Text = "Quantity";
            this.ItemForQuantity.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForDiscount
            // 
            this.ItemForDiscount.Control = this.DiscountTextEdit;
            this.ItemForDiscount.Location = new System.Drawing.Point(0, 72);
            this.ItemForDiscount.Name = "ItemForDiscount";
            this.ItemForDiscount.Size = new System.Drawing.Size(355, 24);
            this.ItemForDiscount.Text = "Discount";
            this.ItemForDiscount.TextSize = new System.Drawing.Size(67, 13);
            // 
            // ItemForOrderDate
            // 
            this.ItemForOrderDate.Control = this.OrderDateDateTimeOffsetEdit;
            this.ItemForOrderDate.Location = new System.Drawing.Point(0, 96);
            this.ItemForOrderDate.Name = "ItemForOrderDate";
            this.ItemForOrderDate.Size = new System.Drawing.Size(355, 24);
            this.ItemForOrderDate.Text = "Order Date";
            this.ItemForOrderDate.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(355, 125);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(73, 284);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 1;
            this.OK_button.Text = "OK";
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(254, 284);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 330);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateTimeOffsetEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDateDateTimeOffsetEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.TextEdit UnitPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit QuantityTextEdit;
        private DevExpress.XtraEditors.TextEdit DiscountTextEdit;
        private DevExpress.XtraEditors.DateEdit OrderDateDateTimeOffsetEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuantity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDiscount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOrderDate;
        private DevExpress.XtraEditors.SimpleButton OK_button;
        private DevExpress.XtraEditors.SimpleButton Cancel_button;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}