using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;

                string countryName;

                inputFile = File.OpenText("Countries.txt");

                countriesListBox.Items.Clear();

                while (inputFile.EndOfStream == false)
                {
                    countryName = inputFile.ReadLine();

                    countriesListBox.Items.Add(countryName);

                }

                inputFile.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
