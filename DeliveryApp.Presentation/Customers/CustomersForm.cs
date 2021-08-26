using System;
using System.Collections.Generic;
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
            List<Customer> allCustomers = CustomersLogic.GetAll();
            foreach (Customer customer in allCustomers)
            {
                var listViewItem = new ListViewItem(customer.ToArrString());
                this.lstVwCustomersList.Items.Add(listViewItem);
            }
        }

        private void BtnCreateCustomer_Click(object sender, System.EventArgs e)
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

        private void BtnCancelCreateCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
