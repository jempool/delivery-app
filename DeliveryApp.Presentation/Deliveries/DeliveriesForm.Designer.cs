namespace DeliveryApp.Presentation
{
    partial class DeliveriesForm
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
            this.grpBxDeliveries = new System.Windows.Forms.GroupBox();
            this.btnApplyDeliveriesSearch = new System.Windows.Forms.Button();
            this.lstVwDeliveriesList = new System.Windows.Forms.ListView();
            this.columnHeaderOrderNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCustomer = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDueTime = new System.Windows.Forms.ColumnHeader();
            this.dtTmPckrDeliveriesTo = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrDeliveriesFrom = new System.Windows.Forms.DateTimePicker();
            this.lblToTitle = new System.Windows.Forms.Label();
            this.lblFromTitle = new System.Windows.Forms.Label();
            this.grpBxDeliveries.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxDeliveries
            // 
            this.grpBxDeliveries.Controls.Add(this.btnApplyDeliveriesSearch);
            this.grpBxDeliveries.Controls.Add(this.lstVwDeliveriesList);
            this.grpBxDeliveries.Controls.Add(this.dtTmPckrDeliveriesTo);
            this.grpBxDeliveries.Controls.Add(this.dtTmPckrDeliveriesFrom);
            this.grpBxDeliveries.Controls.Add(this.lblToTitle);
            this.grpBxDeliveries.Controls.Add(this.lblFromTitle);
            this.grpBxDeliveries.Location = new System.Drawing.Point(13, 13);
            this.grpBxDeliveries.Name = "grpBxDeliveries";
            this.grpBxDeliveries.Size = new System.Drawing.Size(523, 425);
            this.grpBxDeliveries.TabIndex = 0;
            this.grpBxDeliveries.TabStop = false;
            this.grpBxDeliveries.Text = " Deliveries ";
            // 
            // btnApplyDeliveriesSearch
            // 
            this.btnApplyDeliveriesSearch.Location = new System.Drawing.Point(358, 45);
            this.btnApplyDeliveriesSearch.Name = "btnApplyDeliveriesSearch";
            this.btnApplyDeliveriesSearch.Size = new System.Drawing.Size(75, 23);
            this.btnApplyDeliveriesSearch.TabIndex = 2;
            this.btnApplyDeliveriesSearch.Text = "Apply";
            this.btnApplyDeliveriesSearch.UseVisualStyleBackColor = true;
            this.btnApplyDeliveriesSearch.Click += new System.EventHandler(this.BtnApplyDeliveriesSearch_Click);
            // 
            // lstVwDeliveriesList
            // 
            this.lstVwDeliveriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOrderNumber,
            this.columnHeaderDate,
            this.columnHeaderCustomer,
            this.columnHeaderStatus,
            this.columnHeaderDueTime});
            this.lstVwDeliveriesList.HideSelection = false;
            this.lstVwDeliveriesList.Location = new System.Drawing.Point(15, 101);
            this.lstVwDeliveriesList.Name = "lstVwDeliveriesList";
            this.lstVwDeliveriesList.Size = new System.Drawing.Size(490, 302);
            this.lstVwDeliveriesList.TabIndex = 10;
            this.lstVwDeliveriesList.UseCompatibleStateImageBehavior = false;
            this.lstVwDeliveriesList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderOrderNumber
            // 
            this.columnHeaderOrderNumber.Text = "Order Number";
            this.columnHeaderOrderNumber.Width = 90;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 95;
            // 
            // columnHeaderCustomer
            // 
            this.columnHeaderCustomer.Text = "Customer";
            this.columnHeaderCustomer.Width = 150;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 70;
            // 
            // columnHeaderDueTime
            // 
            this.columnHeaderDueTime.Text = "Due Time";
            this.columnHeaderDueTime.Width = 80;
            // 
            // dtTmPckrDeliveriesTo
            // 
            this.dtTmPckrDeliveriesTo.CustomFormat = " dd/MM/yyyy";
            this.dtTmPckrDeliveriesTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDeliveriesTo.Location = new System.Drawing.Point(224, 46);
            this.dtTmPckrDeliveriesTo.Name = "dtTmPckrDeliveriesTo";
            this.dtTmPckrDeliveriesTo.Size = new System.Drawing.Size(102, 23);
            this.dtTmPckrDeliveriesTo.TabIndex = 3;
            // 
            // dtTmPckrDeliveriesFrom
            // 
            this.dtTmPckrDeliveriesFrom.CustomFormat = " dd/MM/yyyy";
            this.dtTmPckrDeliveriesFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDeliveriesFrom.Location = new System.Drawing.Point(61, 46);
            this.dtTmPckrDeliveriesFrom.Name = "dtTmPckrDeliveriesFrom";
            this.dtTmPckrDeliveriesFrom.Size = new System.Drawing.Size(100, 23);
            this.dtTmPckrDeliveriesFrom.TabIndex = 2;
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToTitle.Location = new System.Drawing.Point(195, 49);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(23, 15);
            this.lblToTitle.TabIndex = 1;
            this.lblToTitle.Text = "To:";
            // 
            // lblFromTitle
            // 
            this.lblFromTitle.AutoSize = true;
            this.lblFromTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFromTitle.Location = new System.Drawing.Point(15, 49);
            this.lblFromTitle.Name = "lblFromTitle";
            this.lblFromTitle.Size = new System.Drawing.Size(39, 15);
            this.lblFromTitle.TabIndex = 0;
            this.lblFromTitle.Text = "From:";
            // 
            // DeliveriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.grpBxDeliveries);
            this.Name = "DeliveriesForm";
            this.grpBxDeliveries.ResumeLayout(false);
            this.grpBxDeliveries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxDeliveries;
        private System.Windows.Forms.Label lblFromTitle;
        private System.Windows.Forms.DateTimePicker dtTmPckrDeliveriesTo;
        private System.Windows.Forms.DateTimePicker dtTmPckrDeliveriesFrom;
        private System.Windows.Forms.Label lblToTitle;
        private System.Windows.Forms.Button btnApplyDeliveriesSearch;
        private System.Windows.Forms.ListView lstVwDeliveriesList;
        private System.Windows.Forms.ColumnHeader columnHeaderOrderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomer;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderDueTime;
    }
}