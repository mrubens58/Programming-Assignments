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

namespace NumberWriter
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

        private void writeButton_Click(object sender, EventArgs e)
        {
            //declare a new random variable
            Random rand = new Random();

            //declare variables
            int n1, count = 1, num;

            //check if the format is correct and the file exists
            try
            {
                //store the number entered in the text box as an int variable
                num = int.Parse(numTextBox.Text);
                
                //Streamwriter variable
                StreamWriter outputFile;

                //ask the user if the file exists or they want to create a new one
                DialogResult initialDialog = MessageBox.Show("Does this file already exist", "Create File?", MessageBoxButtons.YesNo);

                //the user chooses to create a file
                if (initialDialog == DialogResult.No)
                {
                    //open save file dialog
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        //use the variable to append the new file
                        outputFile = File.AppendText(saveFileDialog1.FileName);
                                                
                        //do this until count equals the number entered
                        while (count <= num)
                        {
                            //generate a random number between 1 and 100
                            n1 = rand.Next(100) + 1;
                            //write the line to the file
                            outputFile.WriteLine(n1);
                            //add one to the count
                            count++;
                        }

                        //close the file and display the message
                        outputFile.Close();
                        MessageBox.Show("The numbers were written!");

                    }
                    //show a message if the user cancels the save dialog
                    else
                    {
                        MessageBox.Show("Operation Canceled!");
                    }


                }
                //do this if the user chose yes
                else
                {
                    //open the open file dialog
                    openFileDialog1.ShowDialog();

                    //create a variable to hold the string
                    string usersFile = openFileDialog1.FileName;

                    //append the output file with the string
                    outputFile = File.AppendText(usersFile);

                    //do this until count equals the number entered
                    while (count <= num)
                    {
                        n1 = rand.Next(100) + 1;
                        outputFile.WriteLine(n1);
                        count++;
                    }

                    //close the file and show a message
                    outputFile.Close();
                    MessageBox.Show("The numbers were written!");
                }




            }

            //show a message if there is an exception
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
