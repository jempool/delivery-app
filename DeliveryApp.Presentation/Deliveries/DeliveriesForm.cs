using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DeliveryApp.Data.Models;
using DeliveryApp.Service;

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

            List<Delivery> filteredDeliveries = DeliveriesService.FilterDeliveriesByDateRange(from, to);

            foreach (Delivery delivery in filteredDeliveries)
            {
                var listViewItem = new ListViewItem(delivery.ToArrString());
                this.lstVwDeliveriesList.Items.Add(listViewItem);
            }
        }

        private void BtnApplyDeliveriesSearch_Click(object sender, System.EventArgs e)
        {
            LoadDeliveriesData();
        }
    }
}
