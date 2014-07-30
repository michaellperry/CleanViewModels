using AssisticantCollections.Models;
using System;

namespace AssisticantCollections.ViewModels
{
    public class ParentHeader : IParentHeader
    {
        private readonly Item _item;

        public ParentHeader(Item item)
        {
            _item = item;            
        }

        public Item Item
        {
            get { return _item; }
        }

        public string Name
        {
            get { return _item.Name; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            var that = obj as ParentHeader;
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
