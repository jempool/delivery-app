namespace DeliveryApp.Presentation
{
    partial class InvoicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxInvoices = new System.Windows.Forms.GroupBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.lblCustomerFono = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceNumberTitle = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblInvoiceTotalTitle = new System.Windows.Forms.Label();
            this.lstVwInvoiceProducts = new System.Windows.Forms.ListView();
            this.columnHeaderProducts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUntPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.lblInvoiceFono = new System.Windows.Forms.Label();
            this.lblInvoiceName = new System.Windows.Forms.Label();
            this.grpBxInvoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxInvoices
            // 
            this.grpBxInvoices.Controls.Add(this.lblCurrency);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceTotal);
            this.grpBxInvoices.Controls.Add(this.lblCustomerFono);
            this.grpBxInvoices.Controls.Add(this.lblCustomerName);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceNumber);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceNumberTitle);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceDate);
            this.grpBxInvoices.Controls.Add(this.lblDateTitle);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceTotalTitle);
            this.grpBxInvoices.Controls.Add(this.lstVwInvoiceProducts);
            this.grpBxInvoices.Controls.Add(this.lblSubTitle);
            this.grpBxInvoices.Controls.Add(this.lblTitle);
            this.grpBxInvoices.Controls.Add(this.btnCloseInvoice);
            this.grpBxInvoices.Controls.Add(this.btnPrintInvoice);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceFono);
            this.grpBxInvoices.Controls.Add(this.lblInvoiceName);
            this.grpBxInvoices.Location = new System.Drawing.Point(10, 10);
            this.grpBxInvoices.Name = "grpBxInvoices";
            this.grpBxInvoices.Size = new System.Drawing.Size(329, 392);
            this.grpBxInvoices.TabIndex = 1;
            this.grpBxInvoices.TabStop = false;
            this.grpBxInvoices.Text = "Invoice";
            // 
            // lblCurrency
            // 
            this.lblCurrency.BackColor = System.Drawing.Color.White;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrency.Location = new System.Drawing.Point(251, 294);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(21, 14);
            this.lblCurrency.TabIndex = 35;
            this.lblCurrency.Text = "Bs.";
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.BackColor = System.Drawing.Color.White;
            this.lblInvoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTotal.Location = new System.Drawing.Point(249, 293);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.lblInvoiceTotal.Size = new System.Drawing.Size(69, 20);
            this.lblInvoiceTotal.TabIndex = 30;
            this.lblInvoiceTotal.Text = "0";
            // 
            // lblCustomerFono
            // 
            this.lblCustomerFono.BackColor = System.Drawing.Color.White;
            this.lblCustomerFono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerFono.Location = new System.Drawing.Point(73, 138);
            this.lblCustomerFono.Name = "lblCustomerFono";
            this.lblCustomerFono.Size = new System.Drawing.Size(223, 20);
            this.lblCustomerFono.TabIndex = 29;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Location = new System.Drawing.Point(73, 107);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(223, 20);
            this.lblCustomerName.TabIndex = 28;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(258, 55);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(43, 13);
            this.lblInvoiceNumber.TabIndex = 27;
            this.lblInvoiceNumber.Text = "007373";
            // 
            // lblInvoiceNumberTitle
            // 
            this.lblInvoiceNumberTitle.AutoSize = true;
            this.lblInvoiceNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNumberTitle.Location = new System.Drawing.Point(214, 55);
            this.lblInvoiceNumberTitle.Name = "lblInvoiceNumberTitle";
            this.lblInvoiceNumberTitle.Size = new System.Drawing.Size(44, 15);
            this.lblInvoiceNumberTitle.TabIndex = 26;
            this.lblInvoiceNumberTitle.Text = "Inv. N°";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(219, 36);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(89, 13);
            this.lblInvoiceDate.TabIndex = 25;
            this.lblInvoiceDate.Text = "04  /  08  /  2021";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateTitle.Location = new System.Drawing.Point(214, 20);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(95, 15);
            this.lblDateTitle.TabIndex = 24;
            this.lblDateTitle.Text = "Day Month Year";
            // 
            // lblInvoiceTotalTitle
            // 
            this.lblInvoiceTotalTitle.AutoSize = true;
            this.lblInvoiceTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTotalTitle.Location = new System.Drawing.Point(18, 300);
            this.lblInvoiceTotalTitle.Name = "lblInvoiceTotalTitle";
            this.lblInvoiceTotalTitle.Size = new System.Drawing.Size(34, 15);
            this.lblInvoiceTotalTitle.TabIndex = 22;
            this.lblInvoiceTotalTitle.Text = "Total";
            // 
            // lstVwInvoiceProducts
            // 
            this.lstVwInvoiceProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProducts,
            this.columnHeaderQty,
            this.columnHeaderUntPrice,
            this.Total});
            this.lstVwInvoiceProducts.HideSelection = false;
            this.lstVwInvoiceProducts.Location = new System.Drawing.Point(18, 190);
            this.lstVwInvoiceProducts.Name = "lstVwInvoiceProducts";
            this.lstVwInvoiceProducts.Size = new System.Drawing.Size(301, 104);
            this.lstVwInvoiceProducts.TabIndex = 21;
            this.lstVwInvoiceProducts.UseCompatibleStateImageBehavior = false;
            this.lstVwInvoiceProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProducts
            // 
            this.columnHeaderProducts.Text = "Products";
            this.columnHeaderProducts.Width = 99;
            // 
            // columnHeaderQty
            // 
            this.columnHeaderQty.Text = "Qty";
            this.columnHeaderQty.Width = 43;
            // 
            // columnHeaderUntPrice
            // 
            this.columnHeaderUntPrice.Text = "Unit Price";
            this.columnHeaderUntPrice.Width = 85;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 68;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSubTitle.Location = new System.Drawing.Point(31, 51);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(72, 25);
            this.lblSubTitle.TabIndex = 10;
            this.lblSubTitle.Text = "Invoice";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(29, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Delivery App";
            // 
            // btnCloseInvoice
            // 
            this.btnCloseInvoice.Location = new System.Drawing.Point(176, 360);
            this.btnCloseInvoice.Name = "btnCloseInvoice";
            this.btnCloseInvoice.Size = new System.Drawing.Size(64, 20);
            this.btnCloseInvoice.TabIndex = 8;
            this.btnCloseInvoice.Text = "Close";
            this.btnCloseInvoice.UseVisualStyleBackColor = true;
            this.btnCloseInvoice.Click += new System.EventHandler(this.BtnCloseInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(83, 360);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(64, 20);
            this.btnPrintInvoice.TabIndex = 7;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // lblInvoiceFono
            // 
            this.lblInvoiceFono.AutoSize = true;
            this.lblInvoiceFono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceFono.Location = new System.Drawing.Point(18, 141);
            this.lblInvoiceFono.Name = "lblInvoiceFono";
            this.lblInvoiceFono.Size = new System.Drawing.Size(37, 15);
            this.lblInvoiceFono.TabIndex = 6;
            this.lblInvoiceFono.Text = "Fono:";
            // 
            // lblInvoiceName
            // 
            this.lblInvoiceName.AutoSize = true;
            this.lblInvoiceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceName.Location = new System.Drawing.Point(18, 107);
            this.lblInvoiceName.Name = "lblInvoiceName";
            this.lblInvoiceName.Size = new System.Drawing.Size(52, 15);
            this.lblInvoiceName.TabIndex = 2;
            this.lblInvoiceName.Text = "Mr/Mrs:";
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 415);
            this.Controls.Add(this.grpBxInvoices);
            this.Name = "InvoicesForm";
            this.grpBxInvoices.ResumeLayout(false);
            this.grpBxInvoices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxInvoices;
        private System.Windows.Forms.Button btnCloseInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Label lblInvoiceFono;
        private System.Windows.Forms.Label lblInvoiceName;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInvoiceTotalTitle;
        private System.Windows.Forms.ListView lstVwInvoiceProducts;
        private System.Windows.Forms.ColumnHeader columnHeaderProducts;
        private System.Windows.Forms.ColumnHeader columnHeaderQty;
        private System.Windows.Forms.ColumnHeader columnHeaderUntPrice;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label lblInvoiceNumberTitle;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerFono;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Label lblCurrency;
    }
}