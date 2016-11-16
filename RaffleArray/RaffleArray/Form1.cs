using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaffleArray
{
    public partial class Form1 : Form
    {

        decimal[] totalDecimal = new decimal[8];
        int groupNumber;
        decimal saleDecimal;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addToTotalButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                groupNumber = int.Parse(groupTextBox.Text) - 1;

                if (groupNumber >= 0 && groupNumber <= 7)
                {
                    saleDecimal = decimal.Parse(salesTextBox.Text);
                    totalDecimal[groupNumber] += saleDecimal;
                }
                else
                {
                    MessageBox.Show("Enter a valid Group Number (1-8)","Data Entry Error", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("please Enter numeric data","Data Entry Error", MessageBoxButtons.OK);
            }


        }

        private void displayTotalsButton_Click(object sender, EventArgs e)
        {
            int localGroupNumber = 1;
            totalsListBox.Items.Clear();

            foreach (decimal oneTotalDecimal in totalDecimal) 
            {
                totalsListBox.Items.Add("The total Sale for Group " + localGroupNumber + " is " + oneTotalDecimal.ToString("C"));
                localGroupNumber++;
            }

        }

    }
}
