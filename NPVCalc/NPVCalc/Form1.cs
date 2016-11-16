using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPVCalc
{
    public partial class Form1 : Form
    {

        //declare variables
        double futureVal, interestRate, presentVal;
        int years;

        public Form1()
        {
            InitializeComponent();
        }


        //close the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //create a method to calculate the present value
        private void PresentValue(double futureVal, double interestRate, int years)
        {

            //claculate present value
            presentVal = futureVal / (Math.Pow((1 + interestRate / 100), (years)));

            //display the present value format as currency
            presentvalueLabel.Text = presentVal.ToString("C");

            
        }


        //execute the PresentValue method when the user clicks the button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            //do this if there are no exceptions
            try
            {
                //set the variables equal to what is entered in the text boxes
                futureVal = double.Parse(futurevalueTextBox.Text);
                interestRate = double.Parse(interestTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                //call the PresentValue method and enter the paramaters 
                PresentValue(futureVal, interestRate, years);
            }

            //display an error message if there is an exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //clear the form
        private void clearButton_Click(object sender, EventArgs e)
        {
            presentvalueLabel.Text = "";
            futurevalueTextBox.Clear();
            interestTextBox.Clear();
            yearsTextBox.Clear();
        }
    }
}
