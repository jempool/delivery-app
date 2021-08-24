
namespace DeliveryApp.Presentation.Orders
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
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.lstVwSearchResult = new System.Windows.Forms.ListView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtBxSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblOrderTitleRight = new System.Windows.Forms.Label();
            this.lblOrderTitleLeft = new System.Windows.Forms.Label();
            this.grpBxOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxOrders
            // 
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
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(308, 103);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(50, 23);
            this.btnEditCustomer.TabIndex = 5;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // lstVwSearchResult
            // 
            this.lstVwSearchResult.HideSelection = false;
            this.lstVwSearchResult.Location = new System.Drawing.Point(21, 94);
            this.lstVwSearchResult.Name = "lstVwSearchResult";
            this.lstVwSearchResult.Size = new System.Drawing.Size(348, 78);
            this.lstVwSearchResult.TabIndex = 4;
            this.lstVwSearchResult.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(260, 65);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(109, 23);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtBxSearchCustomer
            // 
            this.txtBxSearchCustomer.Location = new System.Drawing.Point(21, 65);
            this.txtBxSearchCustomer.Name = "txtBxSearchCustomer";
            this.txtBxSearchCustomer.Size = new System.Drawing.Size(233, 23);
            this.txtBxSearchCustomer.TabIndex = 2;
            // 
            // lblOrderTitleRight
            // 
            this.lblOrderTitleRight.AutoSize = true;
            this.lblOrderTitleRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTitleRight.Location = new System.Drawing.Point(274, 19);
            this.lblOrderTitleRight.Name = "lblOrderTitleRight";
            this.lblOrderTitleRight.Size = new System.Drawing.Size(56, 30);
            this.lblOrderTitleRight.TabIndex = 1;
            this.lblOrderTitleRight.Text = "Order\r\nNumber:";
            // 
            // lblOrderTitleLeft
            // 
            this.lblOrderTitleLeft.AutoSize = true;
            this.lblOrderTitleLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTitleLeft.Location = new System.Drawing.Point(21, 34);
            this.lblOrderTitleLeft.Name = "lblOrderTitleLeft";
            this.lblOrderTitleLeft.Size = new System.Drawing.Size(64, 15);
            this.lblOrderTitleLeft.TabIndex = 0;
            this.lblOrderTitleLeft.Text = "Customer:";
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
    }
}

