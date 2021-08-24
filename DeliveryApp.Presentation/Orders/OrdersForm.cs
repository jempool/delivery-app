using System.Windows.Forms;
using DeliveryApp.Presentation.Customers;


namespace DeliveryApp.Presentation.Orders
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
    }
}
