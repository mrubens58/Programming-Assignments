using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Discount
{
    class Customer:Person
    {
        //Field
        private int _customerNumber;
        

        //constructor
        public Customer()
            
        {
            _customerNumber = 0;        
        }

        public int Cnumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        
        public override void ShowPerson()
        {
            MessageBox.Show("Customer Number: " + _customerNumber + "\n" + "Name: " + Name + "\n" + "Address: " + Address + "\n" + "Phone: " + Phone, "Customer");
        }
    }
}
