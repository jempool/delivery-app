using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Service;

namespace DeliveryApp.Presentation
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomersData();
        }

        private List<Customer> allCustomers;
        private Customer currentCustomer;

        public DialogResult ShowDialog(ref Customer customer)
        {
            DialogResult dialogResult = base.ShowDialog();
            if (currentCustomer != null)
            {
                customer = currentCustomer;                
            }

            return dialogResult;
        }

        private void LoadCustomersData(){
            this.lstVwCustomersList.Items.Clear();
            allCustomers = CustomersService.GetAllCustomers();
            foreach (Customer customer in allCustomers)
            {
                var listViewItem = new ListViewItem(customer.CustomerFormat());
                this.lstVwCustomersList.Items.Add(listViewItem);
            }
        }

        private void BtnCreateCustomer_Click(object sender, System.EventArgs e)
        {
            string customerName = txtBxCustomerName.Text;
            string customerFono = txtBxCustomerFono.Text;
            string customerAddress = txtBxCustomerAddress.Text;
            
            CustomersService.CreateCustomer(customerName, customerFono, customerAddress);
            LoadCustomersData();
            ClearForm();
        }
        
        private void BtnCancelCreateCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtBxCustomerName.Text = string.Empty;
            txtBxCustomerFono.Text = string.Empty;
            txtBxCustomerAddress.Text = string.Empty;
        }

        private void LstVwCustomersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVwCustomersList.SelectedIndices.Count > 0)
            {
                int selectedIndex = lstVwCustomersList.SelectedIndices[0];
                Customer customer = allCustomers[selectedIndex];
                currentCustomer = customer;
                this.Close();
            }
        }
    }
}
