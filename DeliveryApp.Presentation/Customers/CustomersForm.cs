using System;
using System.Windows.Forms;
using DeliveryApp.Logic;

namespace DeliveryApp.Presentation
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, System.EventArgs e)
        {
            string customerName = txtBxCustomerName.Text;
            string customerFono = txtBxCustomerFono.Text;
            string customerAddress = txtBxCustomerAddress.Text;
            CustomersLogic.Create(customerName, customerFono, customerAddress);
        }

        private void btnCancelCreateCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
