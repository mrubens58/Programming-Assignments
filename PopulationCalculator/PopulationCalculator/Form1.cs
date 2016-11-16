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

namespace PopulationCalculator
{
    public partial class Form1 : Form
    {

        //create an array to hold the values
        double[] numbers = new double[41];


        //create a list to hold the values
        //List<double> numbersList = new List<double>();

        

        public Form1()
        {
            InitializeComponent();
        }


        //close the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //do this when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {

            //set the index of the array to 0
            int index = 0;

            //create a variable to old the input data
            StreamReader inputFile;

            //set the variable equal to the specific file
            inputFile = File.OpenText("USPopulation.txt");

            //clear the text box
            populationListBox.Items.Clear();

            //read the files contents into the array
            while (index < numbers.Length && !inputFile.EndOfStream)
            {

                //set the next index in the to the next line of the file
                numbers[index] = double.Parse(inputFile.ReadLine());
                //add one to the index
                index++;

            }

            //close the file
            inputFile.Close();

            //create a variable to count the number of lines in the array
            int count = 0;

            //do this while the count is less than the number of lines
            while (count <= 41)
            {

                //create a variable to hold the difference between the numbers
                double value = numbers[index = count + 1] - numbers[index = count];

                //add the numbers to the list box
                populationListBox.Items.Add(count + 1951 + " " +  value);

                //add the numbers to the list
                //numbersList.Add(value);

                //add one to the count
                count++;
            }
        }

        //do this when the button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {

            //do this if there are no exceptions            
            try
            {

                //declare variables
                double total = 0;
                double average;

                //do this for each index in the array
                for (int index = 0; index < numbers.Length; index++)
                {

                    //add the number in the array to the total
                    total += numbers[index];

                }

                //calculate the average of the total
                average = total / numbers.Length;
                //display the total in the label
                averageLabel.Text = average.ToString();




                //declare a variable for the highest number in the array
                double highest = numbers[0];

                //do this for each index in the array
                for (int index = 1; index < numbers.Length; index++)
                {

                    //compare the index to the highest
                    if (numbers[index] > highest)
                    {
                        //change the highest to the number index
                        highest = numbers[index];
                    }
                     
                    //display the highest in the label                   
                    greatestLabel.Text = highest.ToString();

                }


                //declare a variable for the lowest number in the array
                double lowest = numbers[0];

                //do this for each index in the array
                for (int index = 1; index < numbers.Length; index++)
                {

                    //compare the index to the lowest
                    if (numbers[index] < lowest)
                    {
                        //change the lowest to the number index
                        lowest = numbers[index];
                    }

                    //display the lowest in the label
                    lowestLabel.Text = lowest.ToString();

                }
                


            }

            //show a message if there is an exception
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
