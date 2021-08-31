namespace DeliveryApp.Presentation
{
    partial class CustomersForm
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
            this.grpBxCustomers = new System.Windows.Forms.GroupBox();
            this.lstVwCustomersList = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelCreateCustomer = new System.Windows.Forms.Button();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.lblCustomerFono = new System.Windows.Forms.Label();
            this.txtBxCustomerFono = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtBxCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtBxCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBxCustomers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxCustomers
            // 
            this.grpBxCustomers.Controls.Add(this.btnCancelCreateCustomer);
            this.grpBxCustomers.Controls.Add(this.btnCreateCustomer);
            this.grpBxCustomers.Controls.Add(this.lblCustomerFono);
            this.grpBxCustomers.Controls.Add(this.txtBxCustomerFono);
            this.grpBxCustomers.Controls.Add(this.lblCustomerAddress);
            this.grpBxCustomers.Controls.Add(this.txtBxCustomerAddress);
            this.grpBxCustomers.Controls.Add(this.lblCustomerName);
            this.grpBxCustomers.Controls.Add(this.txtBxCustomerName);
            this.grpBxCustomers.Location = new System.Drawing.Point(11, 11);
            this.grpBxCustomers.Name = "grpBxCustomers";
            this.grpBxCustomers.Size = new System.Drawing.Size(329, 208);
            this.grpBxCustomers.TabIndex = 0;
            this.grpBxCustomers.TabStop = false;
            this.grpBxCustomers.Text = " Add Customer";
            // 
            // lstVwCustomersList
            // 
            this.lstVwCustomersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderFono,
            this.columnHeaderAddress});
            this.lstVwCustomersList.HideSelection = false;
            this.lstVwCustomersList.Location = new System.Drawing.Point(21, 32);
            this.lstVwCustomersList.MultiSelect = false;
            this.lstVwCustomersList.Name = "lstVwCustomersList";
            this.lstVwCustomersList.Size = new System.Drawing.Size(292, 188);
            this.lstVwCustomersList.TabIndex = 9;
            this.lstVwCustomersList.UseCompatibleStateImageBehavior = false;
            this.lstVwCustomersList.View = System.Windows.Forms.View.Details;
            this.lstVwCustomersList.SelectedIndexChanged += new System.EventHandler(this.LstVwCustomersList_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 96;
            // 
            // columnHeaderFono
            // 
            this.columnHeaderFono.Text = "Fono";
            this.columnHeaderFono.Width = 75;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 100;
            // 
            // btnCancelCreateCustomer
            // 
            this.btnCancelCreateCustomer.Location = new System.Drawing.Point(180, 166);
            this.btnCancelCreateCustomer.Name = "btnCancelCreateCustomer";
            this.btnCancelCreateCustomer.Size = new System.Drawing.Size(64, 20);
            this.btnCancelCreateCustomer.TabIndex = 8;
            this.btnCancelCreateCustomer.Text = "Cancel";
            this.btnCancelCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCancelCreateCustomer.Click += new System.EventHandler(this.BtnCancelCreateCustomer_Click);
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(87, 166);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(64, 20);
            this.btnCreateCustomer.TabIndex = 7;
            this.btnCreateCustomer.Text = "Create";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.BtnCreateCustomer_Click);
            // 
            // lblCustomerFono
            // 
            this.lblCustomerFono.AutoSize = true;
            this.lblCustomerFono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerFono.Location = new System.Drawing.Point(18, 78);
            this.lblCustomerFono.Name = "lblCustomerFono";
            this.lblCustomerFono.Size = new System.Drawing.Size(37, 15);
            this.lblCustomerFono.TabIndex = 6;
            this.lblCustomerFono.Text = "Fono:";
            // 
            // txtBxCustomerFono
            // 
            this.txtBxCustomerFono.Location = new System.Drawing.Point(73, 74);
            this.txtBxCustomerFono.Name = "txtBxCustomerFono";
            this.txtBxCustomerFono.Size = new System.Drawing.Size(215, 20);
            this.txtBxCustomerFono.TabIndex = 5;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerAddress.Location = new System.Drawing.Point(18, 114);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(54, 15);
            this.lblCustomerAddress.TabIndex = 4;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // txtBxCustomerAddress
            // 
            this.txtBxCustomerAddress.Location = new System.Drawing.Point(73, 111);
            this.txtBxCustomerAddress.Name = "txtBxCustomerAddress";
            this.txtBxCustomerAddress.Size = new System.Drawing.Size(215, 20);
            this.txtBxCustomerAddress.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.Location = new System.Drawing.Point(18, 43);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(43, 15);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtBxCustomerName
            // 
            this.txtBxCustomerName.Location = new System.Drawing.Point(73, 40);
            this.txtBxCustomerName.Name = "txtBxCustomerName";
            this.txtBxCustomerName.Size = new System.Drawing.Size(215, 20);
            this.txtBxCustomerName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstVwCustomersList);
            this.groupBox1.Location = new System.Drawing.Point(11, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 235);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Customers ";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxCustomers);
            this.Name = "CustomersForm";
            this.grpBxCustomers.ResumeLayout(false);
            this.grpBxCustomers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCustomers;
        private System.Windows.Forms.TextBox txtBxCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerFono;
        private System.Windows.Forms.TextBox txtBxCustomerFono;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtBxCustomerAddress;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnCancelCreateCustomer;
        private System.Windows.Forms.ListView lstVwCustomersList;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFono;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}