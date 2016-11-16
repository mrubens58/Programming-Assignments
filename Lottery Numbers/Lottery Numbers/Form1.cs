using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery_Numbers
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

        private void generateButton_Click(object sender, EventArgs e)
        {
            
            //int[] numbersArray;
            //numbersArray = new int[6];

            //const int SIZE = 6;
            //int[] numbersArray = new int[SIZE] {0, 10, 20, 30, 40, 50};

            //create an array to hold the numbers
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            //create a new random object
            Random rand = new Random();

            //fill the array with the random numbers in the range 0 through 99
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            //display the array elements in the labels
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString();


        }
    }
}
