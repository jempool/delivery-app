using System.Windows.Forms;

namespace DeliveryApp.Presentation
{
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void BtnCloseInvoice_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
