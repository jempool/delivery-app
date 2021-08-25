using System.Windows.Forms;


namespace DeliveryApp.Presentation
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {            
            CustomersForm customersForm = new();
            customersForm.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e)
        {
            // add product
        }

        private void txtBxAddDetails_TextChanged(object sender, System.EventArgs e)
        {
            // add details
        }

        private void btnCreateOrder_Click(object sender, System.EventArgs e)
        {
            // create order
        }

        private void btnCancelOrder_Click(object sender, System.EventArgs e)
        {
            // cancel order
        }
    }
}
