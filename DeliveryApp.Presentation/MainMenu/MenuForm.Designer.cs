namespace DeliveryApp.Presentation
{
    partial class MenuForm
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(23, 56);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Location = new System.Drawing.Point(116, 56);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(75, 23);
            this.btnDeliveries.TabIndex = 1;
            this.btnDeliveries.Text = "Deliveries";
            this.btnDeliveries.UseVisualStyleBackColor = true;
            this.btnDeliveries.Click += new System.EventHandler(this.BtnDeliveries_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(43, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 25);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Delivery App";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 110);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeliveries);
            this.Controls.Add(this.btnOrders);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDeliveries;
        private System.Windows.Forms.Label lblTitle;
    }
}