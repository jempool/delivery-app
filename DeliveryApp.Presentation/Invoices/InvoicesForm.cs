﻿using System.Collections.Generic;
using System.Windows.Forms;
using DeliveryApp.Data.Models;

namespace DeliveryApp.Presentation
{
    public partial class InvoicesForm : Form
    {
        public InvoicesForm(Order order, Customer customer, string invoiceNumber)
        {
            InitializeComponent();
            InitializeFields(order, customer, invoiceNumber);
            LoadProductsData(order.Products);
        }

        private void InitializeFields(Order order, Customer customer, string invoiceNumber)
        {
            this.lblInvoiceNumber.Text = invoiceNumber;
            this.lblCustomerName.Text = customer.Name;
            this.lblCustomerFono.Text = customer.PhoneNumber.ToString();
            this.lblInvoiceTotal.Text = order.TotalPrice.ToString();
            this.lblInvoiceDate.Text = order.DueTime.ToString("dd  /  MM  /  yyyy");
        }

        private void LoadProductsData(List<Product> productList){            
            foreach (Product product in productList)
            {
                var listViewItem = new ListViewItem(product.InvoiceFormat());
                this.lstVwInvoiceProducts.Items.Add(listViewItem);
            }
        }

        private void BtnCloseInvoice_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
