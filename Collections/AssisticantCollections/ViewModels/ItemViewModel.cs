using System;
using System.Collections.Generic;
using System.Linq;
using AssisticantCollections.Models;
using System.Windows.Input;

namespace AssisticantCollections.ViewModels
{
    public class ItemViewModel
    {
        private readonly Document _document;
        private readonly Item _item;
        
        public ItemViewModel(Document document, Item item)
        {
            _document = document;
            _item = item;
        }

        public string Name
        {
            get { return _item.Name; }
            set { _item.Name = value; }
        }

        public IEnumerable<IParentHeader> ParentCandidates
        {
            get
            {
                var root = new List<IParentHeader>
                {
                    new RootParentHeader()
                };
                var actuals =
                    from item in _document.Items
                    where _item.IsValidParent(item)
                    select new ParentHeader(item);

                return root.Concat(actuals);
            }
        }

        public IParentHeader Parent
        {
            set
            {
                _item.Parent = value == null
                    ? null
                    : value.Item;
            }
            get
            {
                return _item.Parent == null
                    ? (IParentHeader)new RootParentHeader()
                    : new ParentHeader(_item.Parent);
            }
        }

        public int Quantity
        {
            get { return _item.Quantity; }
            set { _item.Quantity = value; }
        }

        public decimal Price
        {
            get { return _item.Price; }
            set { _item.Price = value; }
        }

        public void Increment()
        {
            _item.Quantity++;
        }

        public bool CanDecrement
        {
            get { return _item.Quantity > 1; }
        }

        public void Decrement()
        {
            _item.Quantity--;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            ItemViewModel that = obj as ItemViewModel;
            if (that == null)
                return false;
            return Object.Equals(this._item, that._item);
        }

        public override int GetHashCode()
        {
            return _item.GetHashCode();
        }
    }
}
