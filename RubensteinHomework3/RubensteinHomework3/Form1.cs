using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubensteinHomework3
{
    public partial class Form1 : Form
    {

        //declare public variables to be used in making calculations
        decimal workshopCost, locationCost, totalCost;
        int days;

        public Form1()
        {
            InitializeComponent();
        }


        //close the form when this button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //display the cost when the user makes a selection from the list
        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //decalre a string variable for the location
            string locationString;

            //check if a selection is made from the list
            if(locationListBox.SelectedIndex != -1)
            {
                //set the string variable equal to the selection
                locationString = locationListBox.SelectedItem.ToString();

                //do this for the selection
                if (locationString == "Austin")
                {
                    //set the location cost and display in the location label
                    locationCost = 150;
                    locationLabel.Text = (locationCost * days).ToString("C");
                }
                else if (locationString == "Chicago")
                {
                    locationCost = 225;
                    locationLabel.Text = (locationCost * days).ToString("C");
                }
                else if (locationString == "Dallas")
                {
                    locationCost = 174;
                    locationLabel.Text = (locationCost * days).ToString("C");
                }
                else if (locationString == "Orlando")
                {
                    locationCost = 300;
                    locationLabel.Text = (locationCost * days).ToString("C");
                }
                else if (locationString == "Phoenix")
                {
                    locationCost = 175;
                    locationLabel.Text = (locationCost * days).ToString("C");
                }
                else if (locationString == "Raleigh")
                {
                    locationCost = 150;
                    locationLabel.Text = (locationCost * days).ToString("C");

                }
                
            }
        }

        //clear the selections
        private void clearButton_Click(object sender, EventArgs e)
        {

            //clear the listbox selections
            workshopListBox.SelectedIndex = -1;
            locationListBox.SelectedIndex = -1;
            //clear the labels
            workshopLabel.Text = "";
            locationLabel.Text = "";
            totalLabel.Text = "";



        }

        private void workshopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string workshopString;

            if (workshopListBox.SelectedIndex != -1)
            {

                workshopString = workshopListBox.SelectedItem.ToString();

                if (workshopString == "Handling Stress")
                {
                    //set the workshopCost and days variables and display in the workshp label
                    workshopCost = 1000;
                    days = 3;
                    workshopLabel.Text = workshopCost.ToString("C");

                }
                else if (workshopString == "Time Management")
                {
                    workshopCost = 800;
                    days = 3;
                    workshopLabel.Text = workshopCost.ToString("C");

                }
                else if (workshopString == "Supervision Skills")
                {
                    workshopCost = 1500;
                    days = 3;
                    workshopLabel.Text = workshopCost.ToString("C");

                }
                else if (workshopString == "Negotiation")
                {
                    workshopCost = 1300;
                    days = 5;
                    workshopLabel.Text = workshopCost.ToString("C");

                }
                else if (workshopString == "How to Interview")
                {
                    workshopCost = 500;
                    days = 1;
                    workshopLabel.Text = workshopCost.ToString("C");

                }

            }
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            
            //check to see if the user has selected from both lists
            if (workshopListBox.SelectedIndex != -1 && locationListBox.SelectedIndex != -1)
            {

                //calculate the total from the selections from each list when the button is clicked
                totalCost = (locationCost * days) + workshopCost;
                //display the total in the label
                
                locationLabel.Text = (locationCost * days).ToString("C");
                totalLabel.Text = totalCost.ToString("C");

            }
            
            //display an error message if the user has not selected from both lists
            else
            {
                MessageBox.Show("Please select a workshop and a location.", "Error");
            }
        }
                
    }
}
