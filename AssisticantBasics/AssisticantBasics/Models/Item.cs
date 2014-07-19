using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assisticant.Collections;
using Assisticant.Fields;

namespace AssisticantBasics.Models
{
    public class Item
    {
        private Observable<string> _name =
            new Observable<string>();
        private Observable<int> _quantity =
            new Observable<int>();

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
    }
}
