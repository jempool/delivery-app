using System;
using System.Collections.Generic;
using System.Linq;
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
            
            // TODO: read order number from the database
            var random = new Random();
            this.lblOrderNumber.Text = random.Next(100, 999).ToString();
        }

        private List<Product> allProducts = new();
        private readonly List<Product> orderProductList = new();
        private List<Customer> allCustomers = new();
        private Customer currentCustomer;

        private void LoadCustomersData(){
            allCustomers = CustomersLogic.GetAll();
            var data = new AutoCompleteStringCollection();
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

        private void BtnAddProduct_Click(object sender, System.EventArgs e)
        {
            int indexProduct = this.cmbBxListProducts.SelectedIndex;
            Product product = allProducts[indexProduct].ShallowCopy();
            product.Details = this.txtBxAddDetails.Text;
            product.Quantity = Convert.ToInt32(this.nmrcUpDwnQtyProduct.Value);
            
            orderProductList.Add(product);
            UpdateTotalPrice();
            
            var listViewItem = new ListViewItem(product.ToArrString());
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
            OrdersLogic.Create(orderNumber, dueTime, totalPrice, customerId, orderProductList);

            ClearForm();
            InvoicesForm invoicesForm = new();
            invoicesForm.ShowDialog();
        }

        private void BtnCancelOrder_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void CmbBxSearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCustomer = this.cmbBxSearchCustomer.SelectedIndex;
            currentCustomer = allCustomers[indexCustomer];
            string selectedCustomer = $"{currentCustomer.Name}\n{currentCustomer.PhoneNumber}\n{currentCustomer.Address}";
            this.lblSearchResult.Text = selectedCustomer;
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
    }
}
