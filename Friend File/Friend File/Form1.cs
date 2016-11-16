using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                StreamWriter outputFile;

                DialogResult initialDialog = MessageBox.Show("Does this file already exist", "Create File?", MessageBoxButtons.YesNo);

                if(initialDialog == DialogResult.No)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        outputFile = File.AppendText(saveFileDialog1.FileName);
                        outputFile.WriteLine(nameTextBox.Text);
                        outputFile.Close();
                        MessageBox.Show("The name was written!");

                    }
                    else
                    {
                        MessageBox.Show("Operation Canceled!");
                    }
                    
                    
                }
                else
                {
                    openFileDialog1.ShowDialog();
                    string usersFile = openFileDialog1.FileName;

                    outputFile = File.AppendText(usersFile);
                    outputFile.WriteLine(nameTextBox.Text);
                    outputFile.Close();
                    MessageBox.Show("The name was written!");
                }

                
                
                
            }

            catch (Exception ex)
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
