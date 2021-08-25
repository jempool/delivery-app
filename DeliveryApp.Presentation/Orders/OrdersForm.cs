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
    }
}
