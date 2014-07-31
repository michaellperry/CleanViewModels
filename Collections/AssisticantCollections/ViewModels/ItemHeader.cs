using System;
using System.Linq;
using AssisticantCollections.Models;
using Assisticant.Fields;
using System.Collections.Generic;

namespace AssisticantCollections.ViewModels
{
    public class ItemHeader
    {
        private readonly Document _document;
        private readonly Item _item;
        private readonly Selection _selection;
        
        public ItemHeader(Document document, Item item, Selection selection)
        {
            _document = document;
            _item = item;
            _selection = selection;
        }

        public Item Item
        {
            get { return _item; }
        }

        public bool Selected
        {
            get { return _selection.SelectedItem == _item; }
            set
            {
                if (value == true)
                    _selection.SelectedItem = _item;
                else if (_selection.SelectedItem == _item)
                    _selection.SelectedItem = null;
            }
        }

        public IEnumerable<ItemHeader> Children
        {
            get
            {
                return
                    from item in _document.Items
                    where item.Parent == _item
                    select new ItemHeader(_document, item, _selection);
            }
        }

        public bool? Checked
        {
            get { return _item.Checked; }
            set { _item.Checked = value ?? false; }
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
