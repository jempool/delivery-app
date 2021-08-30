using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Service;

namespace DeliveryApp.Presentation
{
    public partial class CustomersForm : Form
    {
        private List<Customer> allCustomers;
        private Customer selectedCustomer;

        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomersData();
        }

        public CustomersForm(Customer customerToEdit)
        {
            InitializeComponent();
            LoadCustomersData();
            LoadCustomerToEdit(customerToEdit);
            this.btnCreateCustomer.Text = "Update";
        }
         private void LoadCustomerToEdit(Customer customerToEdit)
         {
            this.txtBxCustomerName.Text = customerToEdit.Name;
            this.txtBxCustomerFono.Text = customerToEdit.PhoneNumber.ToString();
            this.txtBxCustomerAddress.Text = customerToEdit.Address;
            selectedCustomer = customerToEdit;
         }

        private void LoadCustomersData()
        {
            this.lstVwCustomersList.Items.Clear();
            allCustomers = CustomersService.GetAllCustomers();
            foreach (Customer customer in allCustomers)
            {
                var listViewItem = new ListViewItem(customer.CustomerFormat());
                this.lstVwCustomersList.Items.Add(listViewItem);
            }
        }
        
        public DialogResult ShowDialog(ref Customer customer)
        {
            DialogResult dialogResult = base.ShowDialog();
            if (selectedCustomer != null)
            {
                customer = selectedCustomer;                
            }

            return dialogResult;
        }

        private void BtnCreateCustomer_Click(object sender, System.EventArgs e)
        {
            string customerName = txtBxCustomerName.Text;
            string customerFono = txtBxCustomerFono.Text;
            string customerAddress = txtBxCustomerAddress.Text;

            if (this.btnCreateCustomer.Text == "Update")
            {
                Customer customerToUpdate = new(){
                    Id = selectedCustomer.Id,
                    Name = customerName,
                    PhoneNumber = Convert.ToInt32(customerFono),
                    Address = customerAddress,
                };

                CustomersService.UpdateCustomer(customerToUpdate);
                LoadCustomersData();
                ClearForm();
                return;
            }
            
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
                Customer customerSelectedFromList = allCustomers[selectedIndex];
                selectedCustomer = customerSelectedFromList;
                this.Close();
            }
        }
    }
}
