using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NumberReader
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

        private void getButton_Click(object sender, EventArgs e)
        {

            //clear the list box before opening another file
            displayListBox.Items.Clear();

            //do this if there are no exceptions
            try
            {

                //declare a variable
                int total = 0;

                //declare a stream reader variable
                StreamReader inputFile;
                
                //open the open file dialog
                openFileDialog1.ShowDialog();

                //create a variable to hold the string
                string numbers = openFileDialog1.FileName;

                //set the writer variable equal to the string
                inputFile = File.OpenText(numbers);

                

                //do this for each line in the file
                while (inputFile.EndOfStream == false)
                {
                    //variable equals the next line in the file
                    numbers = inputFile.ReadLine();
                    //add the variable to the list box
                    displayListBox.Items.Add(numbers);
                    //add the number to the running total
                    total += int.Parse(numbers);

                }
                //close the file
                inputFile.Close();
                //update the count label
                countLabel.Text = displayListBox.Items.Count.ToString() + " Numbers";
                //update the total label
                totalLabel.Text = "Total: " + total.ToString();

            }
            //display a message if there are exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
