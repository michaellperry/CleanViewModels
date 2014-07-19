using System;
using System.Collections.Generic;
using System.Linq;
using AssisticantBasics.Models;
using System.Windows.Input;
using Assisticant.XAML;

namespace AssisticantBasics.ViewModels
{
    public class ItemViewModel
    {
        private readonly Item _item;

        public ItemViewModel(Item item)
        {
            _item = item;
        }

        public string Name
        {
            get { return _item.Name; }
            set { _item.Name = value; }
        }

        public int Quantity
        {
            get { return _item.Quantity; }
            set { _item.Quantity = value; }
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
