using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assisticant.Collections;
using Assisticant.Fields;

namespace AssisticantCollections.Models
{
    public class Item
    {
        private Observable<string> _name =
            new Observable<string>();
        private Observable<int> _quantity =
            new Observable<int>(1);
        private Observable<decimal> _price =
            new Observable<decimal>();

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity.Value = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price.Value = value; }
        }

        public decimal Total
        {
            get { return _price * _quantity; }
        }
    }
}
