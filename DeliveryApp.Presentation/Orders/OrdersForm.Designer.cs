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
            this.dtTmPckrDueTime = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDueTime = new System.Windows.Forms.Label();
            this.nmrcUpDwnQtyProduct = new System.Windows.Forms.NumericUpDown();
            this.lblOrderQtyProduct = new System.Windows.Forms.Label();
            this.cmbBxListProducts = new System.Windows.Forms.ComboBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lstVwSearchResult = new System.Windows.Forms.ListView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtBxSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblOrderTitleRight = new System.Windows.Forms.Label();
            this.lblOrderTitleLeft = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grpBxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDwnQtyProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxOrders
            // 
            this.grpBxOrders.Controls.Add(this.btnAddProduct);
            this.grpBxOrders.Controls.Add(this.dtTmPckrDueTime);
            this.grpBxOrders.Controls.Add(this.lblOrderDueTime);
            this.grpBxOrders.Controls.Add(this.nmrcUpDwnQtyProduct);
            this.grpBxOrders.Controls.Add(this.lblOrderQtyProduct);
            this.grpBxOrders.Controls.Add(this.cmbBxListProducts);
            this.grpBxOrders.Controls.Add(this.btnEditCustomer);
            this.grpBxOrders.Controls.Add(this.lstVwSearchResult);
            this.grpBxOrders.Controls.Add(this.btnAddCustomer);
            this.grpBxOrders.Controls.Add(this.txtBxSearchCustomer);
            this.grpBxOrders.Controls.Add(this.lblOrderTitleRight);
            this.grpBxOrders.Controls.Add(this.lblOrderTitleLeft);
            this.grpBxOrders.Location = new System.Drawing.Point(13, 13);
            this.grpBxOrders.Name = "grpBxOrders";
            this.grpBxOrders.Size = new System.Drawing.Size(384, 425);
            this.grpBxOrders.TabIndex = 0;
            this.grpBxOrders.TabStop = false;
            this.grpBxOrders.Text = " Orders ";
            // 
            // dtTmPckrDueTime
            // 
            this.dtTmPckrDueTime.CustomFormat = "hh:mm tt dd/MM/yyyy";
            this.dtTmPckrDueTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDueTime.Location = new System.Drawing.Point(87, 180);
            this.dtTmPckrDueTime.Name = "dtTmPckrDueTime";
            this.dtTmPckrDueTime.Size = new System.Drawing.Size(165, 23);
            this.dtTmPckrDueTime.TabIndex = 10;
            // 
            // lblOrderDueTime
            // 
            this.lblOrderDueTime.AutoSize = true;
            this.lblOrderDueTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderDueTime.Location = new System.Drawing.Point(17, 183);
            this.lblOrderDueTime.Name = "lblOrderDueTime";
            this.lblOrderDueTime.Size = new System.Drawing.Size(64, 15);
            this.lblOrderDueTime.TabIndex = 9;
            this.lblOrderDueTime.Text = "Due Time:";
            // 
            // nmrcUpDwnQtyProduct
            // 
            this.nmrcUpDwnQtyProduct.Location = new System.Drawing.Point(204, 215);
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
            this.nmrcUpDwnQtyProduct.Size = new System.Drawing.Size(40, 23);
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
            this.lblOrderQtyProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderQtyProduct.Location = new System.Drawing.Point(168, 218);
            this.lblOrderQtyProduct.Name = "lblOrderQtyProduct";
            this.lblOrderQtyProduct.Size = new System.Drawing.Size(30, 15);
            this.lblOrderQtyProduct.TabIndex = 7;
            this.lblOrderQtyProduct.Text = "Qty:";
            // 
            // cmbBxListProducts
            // 
            this.cmbBxListProducts.FormattingEnabled = true;
            this.cmbBxListProducts.Items.AddRange(new object[] {
            "Product1",
            "Product2",
            "Product3"});
            this.cmbBxListProducts.Location = new System.Drawing.Point(19, 215);
            this.cmbBxListProducts.Name = "cmbBxListProducts";
            this.cmbBxListProducts.Size = new System.Drawing.Size(143, 23);
            this.cmbBxListProducts.TabIndex = 6;
            this.cmbBxListProducts.Text = "Product1";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(306, 103);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(50, 23);
            this.btnEditCustomer.TabIndex = 5;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // lstVwSearchResult
            // 
            this.lstVwSearchResult.HideSelection = false;
            this.lstVwSearchResult.Location = new System.Drawing.Point(19, 94);
            this.lstVwSearchResult.Name = "lstVwSearchResult";
            this.lstVwSearchResult.Size = new System.Drawing.Size(348, 78);
            this.lstVwSearchResult.TabIndex = 4;
            this.lstVwSearchResult.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(258, 65);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(109, 23);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtBxSearchCustomer
            // 
            this.txtBxSearchCustomer.Location = new System.Drawing.Point(19, 65);
            this.txtBxSearchCustomer.Name = "txtBxSearchCustomer";
            this.txtBxSearchCustomer.Size = new System.Drawing.Size(233, 23);
            this.txtBxSearchCustomer.TabIndex = 2;
            // 
            // lblOrderTitleRight
            // 
            this.lblOrderTitleRight.AutoSize = true;
            this.lblOrderTitleRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTitleRight.Location = new System.Drawing.Point(272, 19);
            this.lblOrderTitleRight.Name = "lblOrderTitleRight";
            this.lblOrderTitleRight.Size = new System.Drawing.Size(56, 30);
            this.lblOrderTitleRight.TabIndex = 1;
            this.lblOrderTitleRight.Text = "Order\r\nNumber:";
            // 
            // lblOrderTitleLeft
            // 
            this.lblOrderTitleLeft.AutoSize = true;
            this.lblOrderTitleLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTitleLeft.Location = new System.Drawing.Point(19, 34);
            this.lblOrderTitleLeft.Name = "lblOrderTitleLeft";
            this.lblOrderTitleLeft.Size = new System.Drawing.Size(64, 15);
            this.lblOrderTitleLeft.TabIndex = 0;
            this.lblOrderTitleLeft.Text = "Customer:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(258, 215);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 23);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
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
        private System.Windows.Forms.TextBox txtBxSearchCustomer;
        private System.Windows.Forms.ListView lstVwSearchResult;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.ComboBox cmbBxListProducts;
        private System.Windows.Forms.Label lblOrderQtyProduct;
        private System.Windows.Forms.NumericUpDown nmrcUpDwnQtyProduct;
        private System.Windows.Forms.DateTimePicker dtTmPckrDueTime;
        private System.Windows.Forms.Label lblOrderDueTime;
        private Button btnAddProduct;
    }
}

