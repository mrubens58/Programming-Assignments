using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create a method to show the object info        
        private void ShowPersonInfo(Person person)
        {
            //set the values of the object
            person.Name = nameTextBox.Text;
            person.Address = addressTextBox.Text;
            person.Phone = phoneTextBox.Text;

            //call the method from the object
            person.ShowPerson();
        }
        
        //do this when the button is clicked
        private void customerButton_Click(object sender, EventArgs e)
        {
            //variable to hold the purchase ammount
            decimal pamt;

            //do this if there are no exceptions
            try
            {
                //do this if the box is checked
                if (customerCheckBox.Checked == true)
                {
                    //set the variable equal to the text box
                    pamt = decimal.Parse(purchasesTextBox.Text);

                    //create a variable to hold the discount ammount
                    decimal damt = 0;
                    //assign a value based on the purchase ammount
                    if (pamt < 500)
                    {
                        damt = 0;
                    }
                    else if (pamt >= 500 && pamt < 1000)
                    {
                        damt = 5;
                    }
                    else if (pamt >= 1000 && pamt < 1500)
                    {
                        damt = 6;
                    }
                    else if (pamt >= 1500 && pamt < 2000)
                    {
                        damt = 7;
                    }
                    else if (pamt >= 2000)
                    {
                        damt = 10;
                    }

                    //create a new instance of the preferred customer object
                    PreferredCustomer newPreferred = new PreferredCustomer();

                    //assign values to the object properties
                    newPreferred.Purchase = decimal.Parse(purchasesTextBox.Text);
                    newPreferred.Discount = damt;
                    newPreferred.Cnumber = int.Parse(numberTextBox.Text);

                    //display the discount ammount
                    MessageBox.Show("The discount ammount is " + newPreferred.Discount + "%");

                    //call the ShowPerson method and substitue the properties
                    ShowPersonInfo(newPreferred);

                }

                //do this if the check box is not checked
                else if (customerCheckBox.Checked == false)
                {
                    //create an instance of Customer
                    Customer newCustomer = new Customer();
                    //assign a value to the property
                    newCustomer.Cnumber = int.Parse(numberTextBox.Text);
                    //call the ShowPerson Method
                    ShowPersonInfo(newCustomer);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
