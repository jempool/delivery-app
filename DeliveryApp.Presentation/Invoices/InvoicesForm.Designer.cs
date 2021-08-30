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
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.lblCustomerFono = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceNumberTitle = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblInvoiceTotalTitle = new System.Windows.Forms.Label();
            this.lstVwInvoiceProducts = new System.Windows.Forms.ListView();
            this.columnHeaderProducts = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderQty = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderUntPrice = new System.Windows.Forms.ColumnHeader();
            this.Total = new System.Windows.Forms.ColumnHeader();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.lblInvoiceFono = new System.Windows.Forms.Label();
            this.lblInvoiceName = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
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
            this.grpBxInvoices.Location = new System.Drawing.Point(12, 12);
            this.grpBxInvoices.Name = "grpBxInvoices";
            this.grpBxInvoices.Size = new System.Drawing.Size(384, 452);
            this.grpBxInvoices.TabIndex = 1;
            this.grpBxInvoices.TabStop = false;
            this.grpBxInvoices.Text = "Invoice";
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.BackColor = System.Drawing.Color.White;
            this.lblInvoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoiceTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvoiceTotal.Location = new System.Drawing.Point(291, 338);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.lblInvoiceTotal.Size = new System.Drawing.Size(80, 23);
            this.lblInvoiceTotal.TabIndex = 30;
            this.lblInvoiceTotal.Text = "0";
            // 
            // lblCustomerFono
            // 
            this.lblCustomerFono.BackColor = System.Drawing.Color.White;
            this.lblCustomerFono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerFono.Location = new System.Drawing.Point(85, 159);
            this.lblCustomerFono.Name = "lblCustomerFono";
            this.lblCustomerFono.Size = new System.Drawing.Size(260, 23);
            this.lblCustomerFono.TabIndex = 29;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Location = new System.Drawing.Point(85, 123);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(260, 23);
            this.lblCustomerName.TabIndex = 28;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(301, 63);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(43, 15);
            this.lblInvoiceNumber.TabIndex = 27;
            this.lblInvoiceNumber.Text = "007373";
            // 
            // lblInvoiceNumberTitle
            // 
            this.lblInvoiceNumberTitle.AutoSize = true;
            this.lblInvoiceNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvoiceNumberTitle.Location = new System.Drawing.Point(250, 63);
            this.lblInvoiceNumberTitle.Name = "lblInvoiceNumberTitle";
            this.lblInvoiceNumberTitle.Size = new System.Drawing.Size(44, 15);
            this.lblInvoiceNumberTitle.TabIndex = 26;
            this.lblInvoiceNumberTitle.Text = "Inv. N°";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(255, 42);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(89, 15);
            this.lblInvoiceDate.TabIndex = 25;
            this.lblInvoiceDate.Text = "04  /  08  /  2021";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateTitle.Location = new System.Drawing.Point(250, 23);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(95, 15);
            this.lblDateTitle.TabIndex = 24;
            this.lblDateTitle.Text = "Day Month Year";
            // 
            // lblInvoiceTotalTitle
            // 
            this.lblInvoiceTotalTitle.AutoSize = true;
            this.lblInvoiceTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvoiceTotalTitle.Location = new System.Drawing.Point(21, 346);
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
            this.lstVwInvoiceProducts.Location = new System.Drawing.Point(21, 219);
            this.lstVwInvoiceProducts.Name = "lstVwInvoiceProducts";
            this.lstVwInvoiceProducts.Size = new System.Drawing.Size(350, 119);
            this.lstVwInvoiceProducts.TabIndex = 21;
            this.lstVwInvoiceProducts.UseCompatibleStateImageBehavior = false;
            this.lstVwInvoiceProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProducts
            // 
            this.columnHeaderProducts.Text = "Products";
            this.columnHeaderProducts.Width = 146;
            // 
            // columnHeaderQty
            // 
            this.columnHeaderQty.Text = "Qty";
            this.columnHeaderQty.Width = 50;
            // 
            // columnHeaderUntPrice
            // 
            this.columnHeaderUntPrice.Text = "Unit Price";
            this.columnHeaderUntPrice.Width = 90;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTitle.Location = new System.Drawing.Point(36, 59);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(72, 25);
            this.lblSubTitle.TabIndex = 10;
            this.lblSubTitle.Text = "Invoice";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(34, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 25);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Delivery App";
            // 
            // btnCloseInvoice
            // 
            this.btnCloseInvoice.Location = new System.Drawing.Point(205, 415);
            this.btnCloseInvoice.Name = "btnCloseInvoice";
            this.btnCloseInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnCloseInvoice.TabIndex = 8;
            this.btnCloseInvoice.Text = "Close";
            this.btnCloseInvoice.UseVisualStyleBackColor = true;
            this.btnCloseInvoice.Click += new System.EventHandler(this.BtnCloseInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(97, 415);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnPrintInvoice.TabIndex = 7;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // lblInvoiceFono
            // 
            this.lblInvoiceFono.AutoSize = true;
            this.lblInvoiceFono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvoiceFono.Location = new System.Drawing.Point(21, 163);
            this.lblInvoiceFono.Name = "lblInvoiceFono";
            this.lblInvoiceFono.Size = new System.Drawing.Size(37, 15);
            this.lblInvoiceFono.TabIndex = 6;
            this.lblInvoiceFono.Text = "Fono:";
            // 
            // lblInvoiceName
            // 
            this.lblInvoiceName.AutoSize = true;
            this.lblInvoiceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvoiceName.Location = new System.Drawing.Point(21, 123);
            this.lblInvoiceName.Name = "lblInvoiceName";
            this.lblInvoiceName.Size = new System.Drawing.Size(52, 15);
            this.lblInvoiceName.TabIndex = 2;
            this.lblInvoiceName.Text = "Mr/Mrs:";
            // 
            // lblCurrency
            // 
            this.lblCurrency.BackColor = System.Drawing.Color.White;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrency.Location = new System.Drawing.Point(293, 339);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(25, 16);
            this.lblCurrency.TabIndex = 35;
            this.lblCurrency.Text = "Bs.";
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 479);
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