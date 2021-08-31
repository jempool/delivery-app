﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Service;

namespace DeliveryApp.Presentation
{
    public partial class OrdersForm : Form
    {
        private List<Product> allProducts = new List<Product>();
        private List<Customer> allCustomers = new List<Customer>();
        private List<Product> selectedProductList = new List<Product>();
        private Customer selectedCustomer = new Customer();

        private AutoCompleteStringCollection data;

        public OrdersForm()
        {
            InitializeComponent();
            LoadCustomersData();
            LoadProductsData();
            
            string orderNumber = OrdersService.GetNewOrderNumber();
            this.lblOrderNumber.Text = orderNumber;            
        }

        private void LoadCustomersData(){            
            allCustomers = CustomersService.GetAllCustomers();
            data = new AutoCompleteStringCollection();
            foreach (Customer customer in allCustomers)
            {
                this.cmbBxSearchCustomer.Items.Add(customer.Name);
                data.Add(customer.Name);
            }
            this.cmbBxSearchCustomer.AutoCompleteCustomSource = data;
        }

        private void LoadProductsData(){
            allProducts = ProductsService.GetAllProducts();
            foreach (Product product in allProducts)
            {
                this.cmbBxListProducts.Items.Add(product.Name);
            }
            this.cmbBxListProducts.SelectedIndex = 0;
        }

        private void UpdateTotalPrice()
        {
            int totalPrice = 0;
            foreach (Product product in selectedProductList)
            {
                totalPrice += product.Price * product.Quantity;
            }
            this.lblOrderTotal.Text = totalPrice.ToString();
        }

        private void BtnAddCustomer_Click(object sender, System.EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog(ref selectedCustomer);
            SetSearchResult();   
        }

         private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm(selectedCustomer);
            customersForm.ShowDialog(ref selectedCustomer);
            SetSearchResult();
        }

        private void BtnAddProduct_Click(object sender, System.EventArgs e)
        {
            int indexProduct = this.cmbBxListProducts.SelectedIndex;
            Product product = allProducts[indexProduct].ShallowCopy();
            product.Details = this.txtBxAddDetails.Text;
            product.Quantity = Convert.ToInt32(this.nmrcUpDwnQtyProduct.Value);
            
            selectedProductList.Add(product);
            UpdateTotalPrice();
            
            var listViewItem = new ListViewItem(product.OrderFormat());
            this.lstVwOrderProducts.Items.Add(listViewItem);
            ClearLastSelectedProduct();
        }

        private void BtnCreateOrder_Click(object sender, System.EventArgs e)
        {
            // TODO: No action if no customer selected or at least one prod. selected
            string orderNumber = this.lblOrderNumber.Text;
            DateTime dueTime = this.dtTmPckrDueTime.Value;
            int totalPrice = Convert.ToInt32(this.lblOrderTotal.Text.ToString());
            int customerId = selectedCustomer.Id;
            int insertedOrderID = OrdersService.CreateOrder(orderNumber, dueTime, totalPrice, customerId, selectedProductList);
            
            string invoiceNumber = InvoicesService.GetNewInvoiceNumber();
            DateTime expeditionDate = DateTime.Now;
            InvoicesService.CreateInvoice(invoiceNumber, expeditionDate, insertedOrderID);
            DeliveriesService.CreateDelivery("Pending", insertedOrderID);
            
            Order currentOrder = new Order(){
                Id = insertedOrderID ,
                OrderNumber = orderNumber,
                DueTime = DateTime.Now,
                TotalPrice = totalPrice,
                CustomerId = customerId,
                Products = selectedProductList,
                };

            InvoicesForm invoicesForm = new InvoicesForm(currentOrder, selectedCustomer, invoiceNumber);
            invoicesForm.ShowDialog();
            
            ClearForm();
            ClearData();
        }

        private void BtnCancelOrder_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void CmbBxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string text = this.cmbBxSearchCustomer.Text;
            if (string.IsNullOrEmpty(this.cmbBxSearchCustomer.Text) || string.IsNullOrEmpty(text))
            {
                this.lstVwSearchResults.Visible = false;
                return;         
            }

            allCustomers = CustomersService.GetCustomerByNamePattern(text);

            if (allCustomers.Count == 0)
            {
                return;
            }            
            
            this.lstVwSearchResults.Items.Clear();
            this.lstVwSearchResults.Visible = true;
            
            foreach (Customer customer in allCustomers)
            {
                var listViewItem = new ListViewItem(customer.Name);
                this.lstVwSearchResults.Items.Add(listViewItem);
            }             
        }

        private void ClearLastSelectedProduct()
        {
            this.cmbBxListProducts.SelectedIndex = 0;
            this.nmrcUpDwnQtyProduct.Value = 1;
            this.txtBxAddDetails.Clear();
        }

        private void ClearForm()
        {
            this.cmbBxSearchCustomer.Items.Clear();
            this.cmbBxSearchCustomer.ResetText();
            this.lblSearchResult.Text = string.Empty;
            this.dtTmPckrDueTime.Value = DateTime.Now;
            ClearLastSelectedProduct();
            this.lstVwOrderProducts.Items.Clear();
            this.lblOrderTotal.Text = "0";
        }

        private void ClearData()
        {
            selectedProductList = new List<Product>();
            selectedCustomer = null;
        }

        private void LstVwSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVwSearchResults.SelectedIndices.Count > 0)
            {
                int selectedIndex = lstVwSearchResults.SelectedIndices[0];
                selectedCustomer = allCustomers[selectedIndex];
 
                this.cmbBxSearchCustomer.Text = selectedCustomer.Name;
                this.lstVwSearchResults.Visible = false;
                
                SetSearchResult();
            }
        }

        private void SetSearchResult()
        {
            if (!string.IsNullOrEmpty(selectedCustomer.Name))
            {
                this.cmbBxSearchCustomer.Text = string.Empty;
                string infoCustomer = $"{selectedCustomer.Name}\nFono: {selectedCustomer.PhoneNumber}\nAddress: {selectedCustomer.Address}";
                this.lblSearchResult.Text = infoCustomer;
            }
        }
    }
}
