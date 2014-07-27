using System;
using System.Linq;
using AssisticantCollections.Models;
using Assisticant.Fields;

namespace AssisticantCollections.ViewModels
{
    public class ItemHeader
    {
        private readonly Item _item;

        public ItemHeader(Item item)
        {
            _item = item;
        }

        public Item Item
        {
            get { return _item; }
        }

        public string Name
        {
            get
            {
                return String.Format("{0} ({1} @ {2:c})",
                    _item.Name ?? "<New Item>",
                    _item.Quantity,
                    _item.Price);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            ItemHeader that = obj as ItemHeader;
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