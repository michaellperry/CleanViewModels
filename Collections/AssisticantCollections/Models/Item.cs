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
        private Observable<Item> _parent =
            new Observable<Item>();
        private Observable<bool> _checked =
            new Observable<bool>();

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

        public Item Parent
        {
            get { return _parent; }
            set
            {
                if (IsValidParent(value))
                    _parent.Value = value;
            }
        }

        public bool Checked
        {
            get { return _checked; }
            set { _checked.Value = value; }
        }

        public bool IsValidParent(Item candidate)
        {
            while (true)
            {
                if (candidate == null)
                    return true;
                if (candidate == this)
                    return false;
                candidate = candidate.Parent;
            }
        }
    }
}
