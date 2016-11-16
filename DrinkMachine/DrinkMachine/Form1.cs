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

namespace DrinkMachine
     
{

    //create a structure for the drink inventory
    struct DrinkInventory
    {
        //name the variables in the structure
        public string name;
        public decimal cost;
        public int count;
    }


    public partial class Form1 : Form
    {

        //create a new instance of the structure
        private List<DrinkInventory> drinkList = new List<DrinkInventory>();
        //create an array to hold the drink count
        int[] drinkArray = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        //create a variable to accumulate the total sales
        decimal totalSales;
                        
        //create a method to read the configuration file
        private void ReadFile()
        {

            try
            {
                //create a variable to hold the file data
                StreamReader inputFile;
                //create a variable to hold each line of the file
                string line;

                //create an instance of the structure
                DrinkInventory entry = new DrinkInventory();

                //create a delimiter array to separate the lines in the file
                char[] delim = { ',' };

                //create a variable to hold the array index
                int index = 0;
                //tell the file reader what file to open
                inputFile = File.OpenText("DrinkList.txt");

                //do this for each line while there are lines in the file to read
                while (!inputFile.EndOfStream)
                {
                    //set the variable to the next line in the file
                    line = inputFile.ReadLine();

                    //tokenize the line (creates an array to hold the parts of the line)
                    string[] tokens = line.Split(delim);

                    //stroe the tokens in the entry object
                    entry.name = tokens[0];
                    entry.cost = decimal.Parse(tokens[1]);
                    entry.count = int.Parse(tokens[2]);

                    //add the entry object to the list
                    drinkList.Add(entry);

                    //add the count for each entry to the array
                    drinkArray[index] = entry.count;
                    //add one to the array index
                    index++;

                }

            }
            //show an error message if there are any exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //create a method to display the current count
        private void DisplayCount()
        {
            
            colaLabel.Text = drinkArray[0].ToString();
            rootbeerLabel.Text = drinkArray[1].ToString();
            lemonlimeLabel.Text = drinkArray[2].ToString();
            grapeLabel.Text = drinkArray[3].ToString();
            creamLabel.Text = drinkArray[4].ToString();
            
        }

        //create a method to display the total sales
        private void DispalyTotal()
        {

            totalLabel.Text = totalSales.ToString("C");

        }

        
        //close the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //do this when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //call the methods
            ReadFile();
            DisplayCount();
            DispalyTotal();
        }

        //update the total sales
        private void updateSales(decimal cost)
        {
            //add the cost of the drink to the total
            totalSales += cost;
            //dispaly the new total
            DispalyTotal();
        }

        //update the drink count
        private void updateCount(int index)
        {
            //subtract one from the count in the array
            drinkArray[index] -= 1;
            //display the new count
            DisplayCount();

        }

        //create a method for selling drinks
        private void SellDrink(int index)
        {

            //do this if there are drinks
            if (drinkArray[index] > 0)
            {
                //call the methods and pass the paramaters back
                updateSales(drinkList[index].cost);

                updateCount(index);

            }

            //do this if there are no drinks
            else
            {
                MessageBox.Show("Please make another selection.", "Sold Out", MessageBoxButtons.OK);
            }

        }

        //do this when the user makes a selection
        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            //call the sell drink method and pass back the paramater
            SellDrink(0);            
        }

        private void rootbeerPictureBox_Click(object sender, EventArgs e)
        {
            SellDrink(1);
        }

        private void lemonlimePictureBox_Click(object sender, EventArgs e)
        {
            SellDrink(2);
        }

        private void grapePictureBox_Click(object sender, EventArgs e)
        {
            SellDrink(3);
        }

        private void creamPictureBox_Click(object sender, EventArgs e)
        {
            SellDrink(4);
        }
    }
}
