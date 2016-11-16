using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {
        // Fields
        private string _brand;   // The phone's brand
        private string _model;   // The phone's model
        private string _price;  // Retail price

        // Constructor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = "";
        }

        // Brand property
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // Model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // Price property
        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
