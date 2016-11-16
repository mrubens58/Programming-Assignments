using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubensteinAssignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //This will close the program
            this.Close();
        }

        private void cardPictureBox1_Click(object sender, EventArgs e)
        {
            //this will display the txt when the object is clicked
            displayLabel.Text = "The Two of Clubs";
        }

        private void cardPictureBox2_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "The Eight of Diamonds";
        }

        private void cardPictureBox3_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "The Ace of Spades";
        }

        private void cardPictureBox4_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "The King of Clubs";
        }

        private void cardPictureBox5_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "The Ten of Hearts";
        }

        private void displayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
