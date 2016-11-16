using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        
        private List<Automobile> carList = new List<Automobile>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void GetData(ref Automobile auto)
        {
            try
            {
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Automobile car = new Automobile();

            GetData(ref car);

            carList.Add(car);

            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            makeTextBox.Focus();


        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string output;

            carListBox.Items.Clear();

            foreach (Automobile aCar in carList)
            {

                output = aCar.year + " " + aCar.make + " with " + aCar.mileage + " Miles.";

                carListBox.Items.Add(output);

            }



        }

    }
}
