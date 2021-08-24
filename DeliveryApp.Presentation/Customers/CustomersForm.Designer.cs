
namespace DeliveryApp.Presentation.Customers
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
            this.SuspendLayout();
            // 
            // grpBxCustomers
            // 
            this.grpBxCustomers.Location = new System.Drawing.Point(13, 13);
            this.grpBxCustomers.Name = "grpBxCustomers";
            this.grpBxCustomers.Size = new System.Drawing.Size(384, 425);
            this.grpBxCustomers.TabIndex = 0;
            this.grpBxCustomers.TabStop = false;
            this.grpBxCustomers.Text = " Add Customer";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.grpBxCustomers);
            this.Name = "CustomersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCustomers;
    }
}