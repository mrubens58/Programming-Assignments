using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubensteinHomework2
{
    public partial class Form1 : Form
    {

              
        //clear all the text boxes and labels when the button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            westTextbox.Clear();
            eastTextbox.Clear();
            southTextbox.Clear();

            westLabel.Text = "";
            eastLabel.Text = "";
            southLabel.Text = "";
            totalLabel.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
        }


        //close the program when the button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //calculate the total when the button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {



            //check to see if the user entered a numeric value
            try
            {
                decimal soldWest, soldEast, soldSouth, revTotal;
                const int costWest = 140, costEast = 118, costSouth = 118;

                soldWest = decimal.Parse(westTextbox.Text);
                soldEast = decimal.Parse(eastTextbox.Text);
                soldSouth = decimal.Parse(southTextbox.Text);

                //calculate the total revenue
                revTotal = (soldWest * costWest) + (soldEast * costEast) + (soldSouth * costSouth);


                //calculate the revenue for each zone
                westLabel.Text = (soldWest * costWest).ToString();
                eastLabel.Text = (soldEast * costEast).ToString();
                southLabel.Text = (soldSouth * costSouth).ToString();

                //display the total revenue as text, format as curency
                totalLabel.Text = revTotal.ToString("C");

            }

            //give the user a warning message if the value entered is not numeric
            catch
            {
                MessageBox.Show("Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            


        }
    }
}
