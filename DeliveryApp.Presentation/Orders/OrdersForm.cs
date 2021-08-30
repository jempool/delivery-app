using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Logic;

namespace DeliveryApp.Presentation
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadCustomersData();
            LoadProductsData();
            
            // TODO: read order number from the database (current amount + 1)
            var random = new Random();
            this.lblOrderNumber.Text = random.Next(100, 999).ToString();            
        }

        private List<Product> allProducts = new();
        private List<Product> orderProductList = new();
        private List<Customer> allCustomers = new();
        private Customer currentCustomer;

        private AutoCompleteStringCollection data;

        private void LoadCustomersData(){            
            allCustomers = CustomersLogic.GetAll();
            data = new AutoCompleteStringCollection();
            foreach (Customer customer in allCustomers)
            {
                this.cmbBxSearchCustomer.Items.Add(customer.Name);
                data.Add(customer.Name);
            }
            this.cmbBxSearchCustomer.AutoCompleteCustomSource = data;
        }

        private void LoadProductsData(){
            allProducts = ProductsLogic.GetAll();
            foreach (Product product in allProducts)
            {
                this.cmbBxListProducts.Items.Add(product.Name);
            }
            this.cmbBxListProducts.SelectedIndex = 0;
        }

        private void UpdateTotalPrice()
        {
            int totalPrice = 0;
            foreach (Product product in orderProductList)
            {
                totalPrice += product.Price * product.Quantity;
            }
            this.txtBxOrderTotal.Text = totalPrice.ToString();
        }

        private void BtnAddCustomer_Click(object sender, System.EventArgs e)
        {
            CustomersForm customersForm = new();
            customersForm.ShowDialog();
        }

         private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            // TODO: implement to pass the Customer to be edited
            CustomersForm customersForm = new();
            customersForm.ShowDialog();
        }

        private void BtnAddProduct_Click(object sender, System.EventArgs e)
        {
            int indexProduct = this.cmbBxListProducts.SelectedIndex;
            Product product = allProducts[indexProduct].ShallowCopy();
            product.Details = this.txtBxAddDetails.Text;
            product.Quantity = Convert.ToInt32(this.nmrcUpDwnQtyProduct.Value);
            
            orderProductList.Add(product);
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
            int totalPrice = Convert.ToInt32(this.txtBxOrderTotal.Text.ToString());
            int customerId = currentCustomer.Id;
            int insertedOrderID = OrdersLogic.Create(orderNumber, dueTime, totalPrice, customerId, orderProductList);
            
            // TODO: implement getNewInvoiceNumber
            string invoiceNumber = "333";
            DateTime expeditionDate = DateTime.Now;
            InvoicesLogic.Create(invoiceNumber, expeditionDate, insertedOrderID);
            DeliveriesLogic.Create("Pending", insertedOrderID);

            // TODO: pending OrderId
            Order order = new(){
                Id = 666,
                OrderNumber = orderNumber,
                DueTime = dueTime,
                TotalPrice = totalPrice,
                CustomerId = customerId,
                Products = orderProductList,
                };

            InvoicesForm invoicesForm = new(order, currentCustomer);
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

            allCustomers = CustomersLogic.GetByNamePattern(text);

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
            this.txtBxOrderTotal.Clear();
        }

        private void ClearData()
        {
            orderProductList = new();
            currentCustomer = null;
        }

        private void LstVwSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVwSearchResults.SelectedIndices.Count > 0)
            {
                int selectedIndex = lstVwSearchResults.SelectedIndices[0];
                Customer customer = allCustomers[selectedIndex];
                currentCustomer = customer;

                this.cmbBxSearchCustomer.Text = customer.Name;
                this.lstVwSearchResults.Visible = false;
                string selectedCustomer = $"{customer.Name}\nFono: {customer.PhoneNumber}\nAddress: {customer.Address}";
                this.lblSearchResult.Text = selectedCustomer;
            }
        }
    }
}
