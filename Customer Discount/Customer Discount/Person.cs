using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //need for message box

namespace Customer_Discount
{
    class Person
    {

        //Field
        private string _name;
        private string _address;
        private string _phone;

        //constructor
        public Person()
        {
            _address = "";
            _name = "";
            _phone = "";
        }

        //name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //address property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        //phone property
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        //ShowPerson method
        public virtual void ShowPerson()
        {
            MessageBox.Show("Name: "+ _name + "\n" + "Address: " + _address + "\n" + "Phone: " + _phone, "Person");
        }
    }
}
