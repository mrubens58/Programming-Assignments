using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2Play2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            //Display Italian "good Morning".
            displayLabel.Text = "Buongiorno";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Beunos Dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "Guten Morgen";
        }
    }
}
