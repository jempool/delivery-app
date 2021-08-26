using System;
using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Logic;

namespace DeliveryApp.Presentation
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomersData();
        }

        private void LoadCustomersData(){
            this.lstVwCustomersList.Items.Clear();
            foreach (Customer customer in CustomersLogic.GetAll())
            {
                var listViewItem = new ListViewItem(customer.ToArrString());
                this.lstVwCustomersList.Items.Add(listViewItem);
            }
        }

        private void btnCreateCustomer_Click(object sender, System.EventArgs e)
        {
            string customerName = txtBxCustomerName.Text;
            string customerFono = txtBxCustomerFono.Text;
            string customerAddress = txtBxCustomerAddress.Text;
            
            CustomersLogic.Create(customerName, customerFono, customerAddress);
            LoadCustomersData();

            txtBxCustomerName.Text = string.Empty;
            txtBxCustomerFono.Text = string.Empty;
            txtBxCustomerAddress.Text = string.Empty;
        }

        private void btnCancelCreateCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
