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

namespace ContactList
{
    public partial class Form1 : Form
    {

        List<PersonEntry> personList = new List<PersonEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //create a method to read the text file and store the data
        private void ReadFile()
        {

            //create a streamreader variable
            StreamReader inputFile;
            //create a line variable
            string line;
            //create a delimier to split the line 
            char[] delim = { ',' };
            //open the contacts file
            inputFile = File.OpenText("Contacts.txt");
            //do this for each line in the file
            while (!inputFile.EndOfStream)
            {
                //create a new entry object of the personentry class (this is in the wrong place in all the examples, above the while loop, which was causing the entry object to overwrite each line in the list with the same data
                PersonEntry entry = new PersonEntry();
                //set the variable to the next line in the file
                line = inputFile.ReadLine();

                //tokenize the line (creates an array to hold the parts of the line)
                string[] tokens = line.Split(delim);

                //store the tokens in the entry object
                entry.Name = tokens[0];
                entry.Email = tokens[1];
                entry.Phone = tokens[2];

                //add the entry object to the list
                personList.Add(entry);

                //add the names to the list box, changed this to its own method using the list to help find the error i was having populating the list
                //contactListBox.Items.Add(entry.Name);

            }

        }

        //create a method to dispaly te contact names in the listbox
        private void DisplayNames()
        {
            //do this for each entry in the list
            foreach(PersonEntry entry in personList)
            {
                //add the contact name to the list
                contactListBox.Items.Add(entry.Name);
            }

        }

        
        //do this when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            //call the methods
            ReadFile();
            DisplayNames();
                        
        }

        private void contactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item
            int index = contactListBox.SelectedIndex;

            //create the contact form object
            MyContact myContactForm = new MyContact();

            //set the contactform variables equal to the list item values
            myContactForm.cName = personList[index].Name;
            myContactForm.cEmail = personList[index].Email;
            myContactForm.cPhone = personList[index].Phone;

            //display the price form
            myContactForm.ShowDialog();



        }
    }
}
