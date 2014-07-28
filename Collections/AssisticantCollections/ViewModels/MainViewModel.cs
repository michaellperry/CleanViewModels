using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AssisticantCollections.Models;
using Assisticant;
using Assisticant.Fields;

namespace AssisticantCollections.ViewModels
{
    public class MainViewModel
    {
        private readonly Document _document;
		private readonly Selection _selection;
        private Observable<OrderOptions> _order = new Observable<OrderOptions>(default(OrderOptions));

        public MainViewModel(Document document, Selection selection)
        {
            _document = document;
			_selection = selection;
        }

        public OrderOptions Order
        {
            get { return _order; }
            set { _order.Value = value; }
        }

        public IEnumerable<ItemHeader> Items
        {
            get
            {
                IEnumerable<Item> items = _document.Items;
                if (Order == OrderOptions.Name)
                    items = items.OrderBy(i => i.Name);
                if (Order == OrderOptions.Quantity)
                    items = items.OrderBy(i => i.Quantity);
                if (Order == OrderOptions.Price)
                    items = items.OrderBy(i => i.Price);
                IEnumerable<ItemHeader> itemHeaders = items
                    .Select(i => new ItemHeader(i));
                return itemHeaders;
            }
        }

        public ItemHeader SelectedItem
        {
            get
            {
                return _selection.SelectedItem == null
                    ? null
                    : new ItemHeader(_selection.SelectedItem);
            }
            set
            {
                if (value != null)
                    _selection.SelectedItem = value.Item;
                else
                    _selection.SelectedItem = null;
            }
        }

        public ItemViewModel ItemDetail
        {
            get
            {
                return _selection.SelectedItem == null
                    ? null
                    : new ItemViewModel(_selection.SelectedItem);
            }
        }

        public ICommand AddItem
        {
            get
            {
                return MakeCommand
                    .Do(delegate
                    {
                        _selection.SelectedItem = _document.NewItem();
                    });
            }
        }

        public ICommand DeleteItem
        {
            get
            {
                return MakeCommand
                    .When(() => _selection.SelectedItem != null)
                    .Do(delegate
                    {
                        _document.DeleteItem(_selection.SelectedItem);
                        _selection.SelectedItem = null;
                    });
            }
        }
    }
}
