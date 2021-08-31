using System.Windows.Forms;

namespace DeliveryApp.Presentation
{
    partial class OrdersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxOrders = new System.Windows.Forms.GroupBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lstVwSearchResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.cmbBxSearchCustomer = new System.Windows.Forms.ComboBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblOrderTotalTitle = new System.Windows.Forms.Label();
            this.lstVwOrderProducts = new System.Windows.Forms.ListView();
            this.columnHeaderProducts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUntPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBxAddDetails = new System.Windows.Forms.TextBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dtTmPckrDueTime = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDueTime = new System.Windows.Forms.Label();
            this.nmrcUpDwnQtyProduct = new System.Windows.Forms.NumericUpDown();
            this.lblOrderQtyProduct = new System.Windows.Forms.Label();
            this.cmbBxListProducts = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblOrderTitleRight = new System.Windows.Forms.Label();
            this.lblOrderTitleLeft = new System.Windows.Forms.Label();
            this.grpBxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQtyProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxOrders
            // 
            this.grpBxOrders.Controls.Add(this.lblCurrency);
            this.grpBxOrders.Controls.Add(this.lblOrderTotal);
            this.grpBxOrders.Controls.Add(this.lstVwSearchResults);
            this.grpBxOrders.Controls.Add(this.lblInvoiceTotal);
            this.grpBxOrders.Controls.Add(this.btnEditCustomer);
            this.grpBxOrders.Controls.Add(this.lblSearchResult);
            this.grpBxOrders.Controls.Add(this.cmbBxSearchCustomer);
            this.grpBxOrders.Controls.Add(this.lblOrderNumber);
            this.grpBxOrders.Controls.Add(this.btnCancelOrder);
            this.grpBxOrders.Controls.Add(this.btnCreateOrder);
            this.grpBxOrders.Controls.Add(this.lblOrderTotalTitle);
            this.grpBxOrders.Controls.Add(this.lstVwOrderProducts);
            this.grpBxOrders.Controls.Add(this.txtBxAddDetails);
            this.grpBxOrders.Controls.Add(this.lblOrderDetails);
            this.grpBxOrders.Controls.Add(this.btnAddProduct);
            this.grpBxOrders.Controls.Add(this.dtTmPckrDueTime);
            this.grpBxOrders.Controls.Add(this.lblOrderDueTime);
            this.grpBxOrders.Controls.Add(this.nmrcUpDwnQtyProduct);
            this.grpBxOrders.Controls.Add(this.lblOrderQtyProduct);
            this.grpBxOrders.Controls.Add(this.cmbBxListProducts);
            this.grpBxOrders.Controls.Add(this.btnAddCustomer);
            this.grpBxOrders.Controls.Add(this.lblOrderTitleRight);
            this.grpBxOrders.Controls.Add(this.lblOrderTitleLeft);
            this.grpBxOrders.Location = new System.Drawing.Point(11, 11);
            this.grpBxOrders.Name = "grpBxOrders";
            this.grpBxOrders.Size = new System.Drawing.Size(329, 450);
            this.grpBxOrders.TabIndex = 0;
            this.grpBxOrders.TabStop = false;
            this.grpBxOrders.Text = " Orders ";
            // 
            // lblCurrency
            // 
            this.lblCurrency.BackColor = System.Drawing.Color.White;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrency.Location = new System.Drawing.Point(215, 380);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(21, 14);
            this.lblCurrency.TabIndex = 34;
            this.lblCurrency.Text = "Bs.";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BackColor = System.Drawing.Color.White;
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderTotal.Location = new System.Drawing.Point(214, 378);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.lblOrderTotal.Size = new System.Drawing.Size(101, 20);
            this.lblOrderTotal.TabIndex = 33;
            this.lblOrderTotal.Text = "0";
            // 
            // lstVwSearchResults
            // 
            this.lstVwSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstVwSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstVwSearchResults.HideSelection = false;
            this.lstVwSearchResults.Location = new System.Drawing.Point(16, 77);
            this.lstVwSearchResults.MultiSelect = false;
            this.lstVwSearchResults.Name = "lstVwSearchResults";
            this.lstVwSearchResults.Size = new System.Drawing.Size(212, 85);
            this.lstVwSearchResults.TabIndex = 32;
            this.lstVwSearchResults.UseCompatibleStateImageBehavior = false;
            this.lstVwSearchResults.View = System.Windows.Forms.View.Details;
            this.lstVwSearchResults.Visible = false;
            this.lstVwSearchResults.SelectedIndexChanged += new System.EventHandler(this.LstVwSearchResults_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.BackColor = System.Drawing.Color.White;
            this.lblInvoiceTotal.Location = new System.Drawing.Point(196, 57);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(17, 16);
            this.lblInvoiceTotal.TabIndex = 31;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(262, 89);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(43, 20);
            this.btnEditCustomer.TabIndex = 5;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.BackColor = System.Drawing.Color.White;
            this.lblSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchResult.Location = new System.Drawing.Point(16, 82);
            this.lblSearchResult.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(295, 54);
            this.lblSearchResult.TabIndex = 23;
            // 
            // cmbBxSearchCustomer
            // 
            this.cmbBxSearchCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbBxSearchCustomer.FormattingEnabled = true;
            this.cmbBxSearchCustomer.Location = new System.Drawing.Point(16, 56);
            this.cmbBxSearchCustomer.Name = "cmbBxSearchCustomer";
            this.cmbBxSearchCustomer.Size = new System.Drawing.Size(199, 21);
            this.cmbBxSearchCustomer.TabIndex = 22;
            this.cmbBxSearchCustomer.TextChanged += new System.EventHandler(this.CmbBxSearchCustomer_TextChanged);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(259, 32);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(55, 13);
            this.lblOrderNumber.TabIndex = 21;
            this.lblOrderNumber.Text = "ORD0001";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(171, 417);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(64, 20);
            this.btnCancelOrder.TabIndex = 18;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(75, 417);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(64, 20);
            this.btnCreateOrder.TabIndex = 17;
            this.btnCreateOrder.Text = "Create";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.BtnCreateOrder_Click);
            // 
            // lblOrderTotalTitle
            // 
            this.lblOrderTotalTitle.AutoSize = true;
            this.lblOrderTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderTotalTitle.Location = new System.Drawing.Point(15, 385);
            this.lblOrderTotalTitle.Name = "lblOrderTotalTitle";
            this.lblOrderTotalTitle.Size = new System.Drawing.Size(34, 15);
            this.lblOrderTotalTitle.TabIndex = 16;
            this.lblOrderTotalTitle.Text = "Total";
            // 
            // lstVwOrderProducts
            // 
            this.lstVwOrderProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProducts,
            this.columnHeaderQty,
            this.columnHeaderUntPrice});
            this.lstVwOrderProducts.HideSelection = false;
            this.lstVwOrderProducts.Location = new System.Drawing.Point(15, 275);
            this.lstVwOrderProducts.Name = "lstVwOrderProducts";
            this.lstVwOrderProducts.Size = new System.Drawing.Size(301, 104);
            this.lstVwOrderProducts.TabIndex = 14;
            this.lstVwOrderProducts.UseCompatibleStateImageBehavior = false;
            this.lstVwOrderProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProducts
            // 
            this.columnHeaderProducts.Text = "Products";
            this.columnHeaderProducts.Width = 144;
            // 
            // columnHeaderQty
            // 
            this.columnHeaderQty.Text = "Qty";
            this.columnHeaderQty.Width = 48;
            // 
            // columnHeaderUntPrice
            // 
            this.columnHeaderUntPrice.Text = "Unit Price";
            this.columnHeaderUntPrice.Width = 100;
            // 
            // txtBxAddDetails
            // 
            this.txtBxAddDetails.Location = new System.Drawing.Point(63, 217);
            this.txtBxAddDetails.Multiline = true;
            this.txtBxAddDetails.Name = "txtBxAddDetails";
            this.txtBxAddDetails.Size = new System.Drawing.Size(253, 46);
            this.txtBxAddDetails.TabIndex = 13;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderDetails.Location = new System.Drawing.Point(16, 224);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(48, 15);
            this.lblOrderDetails.TabIndex = 12;
            this.lblOrderDetails.Text = "Details:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(221, 186);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(93, 20);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // dtTmPckrDueTime
            // 
            this.dtTmPckrDueTime.CustomFormat = " dd/MM/yyyy hh:mm tt";
            this.dtTmPckrDueTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDueTime.Location = new System.Drawing.Point(85, 156);
            this.dtTmPckrDueTime.Name = "dtTmPckrDueTime";
            this.dtTmPckrDueTime.Size = new System.Drawing.Size(142, 20);
            this.dtTmPckrDueTime.TabIndex = 10;
            // 
            // lblOrderDueTime
            // 
            this.lblOrderDueTime.AutoSize = true;
            this.lblOrderDueTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderDueTime.Location = new System.Drawing.Point(15, 159);
            this.lblOrderDueTime.Name = "lblOrderDueTime";
            this.lblOrderDueTime.Size = new System.Drawing.Size(64, 15);
            this.lblOrderDueTime.TabIndex = 9;
            this.lblOrderDueTime.Text = "Due Time:";
            // 
            // nmrcUpDwnQtyProduct
            // 
            this.nmrcUpDwnQtyProduct.Location = new System.Drawing.Point(175, 186);
            this.nmrcUpDwnQtyProduct.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrcUpDwnQtyProduct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcUpDwnQtyProduct.Name = "nmrcUpDwnQtyProduct";
            this.nmrcUpDwnQtyProduct.Size = new System.Drawing.Size(34, 20);
            this.nmrcUpDwnQtyProduct.TabIndex = 8;
            this.nmrcUpDwnQtyProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblOrderQtyProduct
            // 
            this.lblOrderQtyProduct.AutoSize = true;
            this.lblOrderQtyProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderQtyProduct.Location = new System.Drawing.Point(144, 189);
            this.lblOrderQtyProduct.Name = "lblOrderQtyProduct";
            this.lblOrderQtyProduct.Size = new System.Drawing.Size(30, 15);
            this.lblOrderQtyProduct.TabIndex = 7;
            this.lblOrderQtyProduct.Text = "Qty:";
            // 
            // cmbBxListProducts
            // 
            this.cmbBxListProducts.FormattingEnabled = true;
            this.cmbBxListProducts.Location = new System.Drawing.Point(16, 186);
            this.cmbBxListProducts.Name = "cmbBxListProducts";
            this.cmbBxListProducts.Size = new System.Drawing.Size(123, 21);
            this.cmbBxListProducts.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(221, 56);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(93, 20);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // lblOrderTitleRight
            // 
            this.lblOrderTitleRight.AutoSize = true;
            this.lblOrderTitleRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitleRight.Location = new System.Drawing.Point(231, 16);
            this.lblOrderTitleRight.Name = "lblOrderTitleRight";
            this.lblOrderTitleRight.Size = new System.Drawing.Size(92, 15);
            this.lblOrderTitleRight.TabIndex = 1;
            this.lblOrderTitleRight.Text = "Order Number:";
            // 
            // lblOrderTitleLeft
            // 
            this.lblOrderTitleLeft.AutoSize = true;
            this.lblOrderTitleLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderTitleLeft.Location = new System.Drawing.Point(16, 29);
            this.lblOrderTitleLeft.Name = "lblOrderTitleLeft";
            this.lblOrderTitleLeft.Size = new System.Drawing.Size(64, 15);
            this.lblOrderTitleLeft.TabIndex = 0;
            this.lblOrderTitleLeft.Text = "Customer:";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 471);
            this.Controls.Add(this.grpBxOrders);
            this.Name = "OrdersForm";
            this.grpBxOrders.ResumeLayout(false);
            this.grpBxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQtyProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOrders;
        private System.Windows.Forms.Label lblOrderTitleLeft;
        private System.Windows.Forms.Label lblOrderTitleRight;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.ComboBox cmbBxListProducts;
        private System.Windows.Forms.Label lblOrderQtyProduct;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnQtyProduct;
        private System.Windows.Forms.DateTimePicker dtTmPckrDueTime;
        private System.Windows.Forms.Label lblOrderDueTime;
        private Button btnAddProduct;
        private TextBox txtBxAddDetails;
        private Label lblOrderDetails;
        private ListView lstVwOrderProducts;
        private Label lblOrderTotalTitle;
        private ColumnHeader columnHeaderProducts;
        private ColumnHeader columnHeaderQty;
        private ColumnHeader columnHeaderUntPrice;
        private Button btnCancelOrder;
        private Button btnCreateOrder;
        private Label lblOrderNumber;
        private ComboBox cmbBxSearchCustomer;
        private Label lblSearchResult;
        private Label lblInvoiceTotal;
        private ListView lstVwSearchResults;
        private ColumnHeader columnHeader1;
        private Label lblOrderTotal;
        private Label lblCurrency;
    }
}

