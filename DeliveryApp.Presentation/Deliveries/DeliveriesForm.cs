using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Logic;

namespace DeliveryApp.Presentation
{
    public partial class DeliveriesForm : Form
    {
        public DeliveriesForm()
        {
            InitializeComponent();
            LoadDeliveriesData();
        }

        private void LoadDeliveriesData(){
            this.lstVwDeliveriesList.Items.Clear();
            foreach (Delivery delivery in DeliveriesLogic.GetAll())
            {
                var listViewItem = new ListViewItem(delivery.ToArrString());
                this.lstVwDeliveriesList.Items.Add(listViewItem);
            }
        }

        private void btnApplyDeliveriesSearch_Click(object sender, System.EventArgs e)
        {
            // Filter deliveries
        }
    }
}
