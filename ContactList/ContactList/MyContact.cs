using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MyContact : Form
    {

        string contactName;
        string contactPhone;
        string contactEmail;

        public string cName
        {
            set
            {
                contactName = value;
            }
        }

        public string cPhone
        {
            set
            {
                contactPhone = value;
            }
        }

        public string cEmail
        {
            set
            {
                contactEmail = value;
            }
        }


        public MyContact()
        {
            InitializeComponent();
        }

        private void MyContact_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Name: " + contactName;
            emailLabel.Text = "email: " + contactEmail;
            phoneLabel.Text = "Phone: " + contactPhone;
        }
    }
}
