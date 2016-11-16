using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {

        //declare random variable
        Random rand = new Random();
        //public variables to hold the random number and number of guesses
        int n1, guess, numGuesses = 0;


        
        public Form1()
        {
            InitializeComponent();

            //set the first random number when the game starts
            n1 = rand.Next(100) + 1;

        }

        //close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //select the text to make it easier for the user to enter another number
        private void guessTextBox_Click(object sender, EventArgs e)
        {
            //selects the text in the textbox when the user clicks
            guessTextBox.SelectAll();

        }

        //let the use press enter instead of clicking the guess button
        private void guessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //do something when the enter button is down
            if (e.KeyCode == Keys.Enter)
            {
                //do the guess button click when the key is down
                guessButton_Click(null, null);

                //select the text after the use presses enter to make it easier
                guessTextBox.SelectAll();
            }
        }

        //do this when the guess button is clicked
        private void guessButton_Click(object sender, EventArgs e)
        {

            //check to se if the user enters an integer
            try
            {
                guess = int.Parse(guessTextBox.Text);

                //do this if the try passes and the int is between 1 and 100
                if (guess >= 1 && guess <= 100)
                {

                    //add one to the number of guesses
                    numGuesses += 1;

                    //display messages in the label
                    if (guess > n1)
                    {
                        displayLabel.Text = "Too High, Guess Again";
                    }
                    else if (guess < n1)
                    {
                        displayLabel.Text = "Too Low, Guess Again";
                    }
                    else if (guess == n1)
                    {
                        displayLabel.Text = n1.ToString() + " Congratulations! " + numGuesses.ToString() +" Guesses";
                    }

                }

                //display an error message if the guess is not between 1 and 100
                else
                {
                    MessageBox.Show("Pick a number between 1 and 100", "Error", MessageBoxButtons.OK);
                }
                                
             //display an error message if guess is not an int   
            }
            catch
            {
                MessageBox.Show("Please enter a numeric value","Eror", MessageBoxButtons.OK);
            }



        }

        //restart the game
        private void resetButton_Click(object sender, EventArgs e)
        {
            numGuesses = 0;

            n1 = rand.Next(100) + 1;

            displayLabel.Text = "Enter a number between 1 and 100.";

            guessTextBox.Clear();
        }
    }
}
