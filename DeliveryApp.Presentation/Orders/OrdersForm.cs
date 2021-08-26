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
            LoadProductsData();
        }

        private void LoadProductsData(){
            List<Product> allProducts = ProductsLogic.GetAll();
            this.cmbBxListProducts.Text = allProducts[0].Name;
            foreach (Product product in allProducts)
            {
                this.cmbBxListProducts.Items.Add(product.Name);
            }
        }

        private void BtnAddCustomer_Click(object sender, System.EventArgs e)
        {            
            CustomersForm customersForm = new();
            customersForm.ShowDialog();
        }

        private void BtnAddProduct_Click(object sender, System.EventArgs e)
        {
            // add product
        }

        private void TxtBxAddDetails_TextChanged(object sender, System.EventArgs e)
        {
            // add details
        }

        private void BtnCreateOrder_Click(object sender, System.EventArgs e)
        {
            InvoicesForm invoicesForm = new();
            invoicesForm.ShowDialog();
        }

        private void BtnCancelOrder_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
