using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyShopUI.Factory;

namespace AnyShopUI.Forms
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void ButtonStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form= FormFactory.Show("STOCK");
            form.Show();
        }

        private void ButtonInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFactory.Show("INVOICE").Show();
        }

        private void ButtonDailyBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFactory.Show("DAILYBOOK").Show();
        }

        private void ButtonCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFactory.Show("CUSTOMER").Show();
        }

        private void Vendor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFactory.Show("VENDOR").Show();
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFactory.Show("REPORT").Show();
        }
    }
}
