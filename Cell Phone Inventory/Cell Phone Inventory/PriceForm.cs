using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class PriceForm : Form
    {
        string phonePrice;

        public string PhonePr
        {
            set
            {
                phonePrice = value;
            }
        }
       
        public PriceForm()
        {
            InitializeComponent();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            decimal priceDecimal;

            if (decimal.TryParse(phonePrice, out priceDecimal))
            {
                label1.Text = "Price: " + priceDecimal.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Price");
                this.Close();
            }
        }
    }
}
