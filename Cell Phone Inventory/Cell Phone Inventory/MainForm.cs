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
    public partial class MainForm : Form
    {
        
        //list to hold cell phone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public MainForm()
        {
            InitializeComponent();
        }



        //the get the phone method accepts a cellphone object as an argument
        private void GetPhoneData(CellPhone phone)
        {
            
            //Get the phone's brand
            phone.Brand = brandTextBox.Text;

            //Get the phone's model
            phone.Model = modelTextBox.Text;

            //get the phones price
            phone.Price = priceTextBox.Text;



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            //create a cellphone object
            CellPhone myPhone = new CellPhone();

            //get the phone data
            GetPhoneData(myPhone);

            //add the cellphone object to the list
            phoneList.Add(myPhone);

            //add an entry to the list box
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            //clear text boxes
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            //reset the focus
            brandTextBox.Focus();



        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item
            int index = phoneListBox.SelectedIndex;

            //create the price form object
            PriceForm myPriceForm = new PriceForm();

            myPriceForm.PhonePr = phoneList[index].Price;

            //display the price form
            myPriceForm.ShowDialog();

        }
    }
}
