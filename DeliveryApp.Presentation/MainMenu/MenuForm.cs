using System.Windows.Forms;

namespace DeliveryApp.Presentation
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnOrders_Click(object sender, System.EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void BtnDeliveries_Click(object sender, System.EventArgs e)
        {
            DeliveriesForm deliveriesForm = new DeliveriesForm();
            deliveriesForm.ShowDialog();
        }
    }
}
