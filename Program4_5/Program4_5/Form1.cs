using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //declare variables

            double distanceDouble;
            string convertFrom, convertTo;

            try
            {
                distanceDouble = double.Parse(distanceTextBox.Text);

                //check to make sure there is a selection from both boxes

                if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
                {
                    convertFrom = fromListBox.SelectedItem.ToString();
                    convertTo = toListBox.SelectedItem.ToString();

                    if (convertFrom == convertTo)
                    {
                        convertedLabel.Text = distanceDouble.ToString();
                    }
                    else if (convertFrom == "Yards" && convertTo == "Feet") 
                    {
                        convertedLabel.Text = (distanceDouble * 3).ToString();
                    }
                    else if (convertFrom == "Feet" && convertTo == "Yards")
                    {
                        convertedLabel.Text = (distanceDouble/3).ToString();
                    }
                    else if (convertFrom == "Yards" && convertTo == "Inches")
                    {
                        convertedLabel.Text = (distanceDouble * 3*12).ToString();
                    }
                    else if (convertFrom == "Inches" && convertTo == "Yards")
                    {
                        convertedLabel.Text = (distanceDouble/3 /12).ToString();
                    }
                    else if (convertFrom == "Feet" && convertTo == "Inches")
                    {
                        convertedLabel.Text = (distanceDouble * 12).ToString();
                    }
                    else if (convertFrom == "Inches" && convertTo == "Feet")
                    {
                        convertedLabel.Text = (distanceDouble/12).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("please make a selecton from both boxes", "Error");
                }

            }
            catch
            {
                MessageBox.Show("Please enter a numeric value.", "Error");
            }

            


        }
    }
}
