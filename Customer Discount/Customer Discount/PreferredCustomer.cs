using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Discount
{
    class PreferredCustomer:Customer
    {

        //Field
        private decimal _purchase;
        private decimal _discount;


        //constructor
        public PreferredCustomer()

        {
            _purchase = 0;
            _discount = 0;
        }

        public decimal Purchase
        {
            get { return _purchase; }
            set { _purchase = value; }
        }

        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }


        public override void ShowPerson()
        {
            MessageBox.Show("Customer Number: " + Cnumber + "\n" + "Name: " + Name + "\n" + "Address: " + Address + "\n" + "Phone: " + Phone + "\n" +  "Purchase Ammount: " + _purchase.ToString("C") + "\n" + "Discount: " + _discount + "%", "Preferred Customer");
        }

    }
}
