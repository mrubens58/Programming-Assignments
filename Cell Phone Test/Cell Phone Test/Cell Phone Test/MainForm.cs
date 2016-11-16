using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetPhoneData(CellPhone phone)
        {
            //Temporary variable to hold the price
            decimal price;

            //Get the phone's brand
            phone.Brand = brandTextBox.Text;

            //Get the phone's model
            phone.Model = modelTextBox.Text;

            //Get the phone's price
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid Price");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create the CellPhone object
            CellPhone myPhone = new CellPhone();

            //Get the phone data
            GetPhoneData(myPhone);

            //Display the phone data
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("C");
        }
    }
}
