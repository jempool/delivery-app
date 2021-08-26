using System;
using System.Collections.Generic;
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

            DateTime from = this.dtTmPckrDeliveriesFrom.Value;
            DateTime to = this.dtTmPckrDeliveriesTo.Value;

            List<Delivery> filteredDeliveries = DeliveriesLogic.FilterByDateRange(from, to);

            foreach (Delivery delivery in filteredDeliveries)
            {
                var listViewItem = new ListViewItem(delivery.ToArrString());
                this.lstVwDeliveriesList.Items.Add(listViewItem);
            }
        }

        private void btnApplyDeliveriesSearch_Click(object sender, System.EventArgs e)
        {
            LoadDeliveriesData();
        }
    }
}
