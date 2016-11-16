using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        decimal[,] rateDecimal = new decimal[,] {{1m, 1.5m, 1.65m, 1.85m},
                                                      {1.58m, 2m, 2.4m, 3.05m},
                                                      {1.71m, 2.52m, 3.1m, 4m},
                                                      {2.04m, 3.12m, 4m, 5.01m},
                                                      {2.52m, 3.75m, 5.1m, 7.25m}};

        private void lookUpButton_Click(object sender, EventArgs e)
        {
            
            int weight = weightListBox.SelectedIndex;
            int zone = zoneListBox.SelectedIndex;

            if (weight != -1 && zone != -1)
            {
                chargesLabel.Text = rateDecimal[weight, zone].ToString("C");
            }
            else
            {
                MessageBox.Show("Please select a weight and a zone.", "Information", MessageBoxButtons.OK);
            }
        }
    }
}
