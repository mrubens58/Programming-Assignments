using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        //field to hold a list of phonebookentry object
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;
                string line;

                //create an instance of the structure
                PhoneBookEntry entry = new PhoneBookEntry();

                //create a delimiter array
                char[] delim = { ',' };

                inputFile = File.OpenText("PhoneList.txt");

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    //tokenize the line
                    string[] tokens = line.Split(delim);

                    //stroe the tokens in the entry object
                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    //add the entry object to the list
                    phoneList.Add(entry);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;

            phoneLabel.Text = phoneList[index].phone;
        }
    }
}
