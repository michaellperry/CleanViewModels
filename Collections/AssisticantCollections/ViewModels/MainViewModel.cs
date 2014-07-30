using Assisticant;
using AssisticantCollections.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace AssisticantCollections.ViewModels
{
    public class MainViewModel
    {
        private readonly Document _document;
		private readonly Selection _selection;

        public MainViewModel(Document document, Selection selection)
        {
            _document = document;
			_selection = selection;
        }

        public IEnumerable<ItemHeader> Items
        {
            get
            {
                return
                    from item in _document.Items
                    where item.Parent == null
                    select new ItemHeader(_document, item, _selection);
            }
        }

        public ItemHeader SelectedItem
        {
            get
            {
                return _selection.SelectedItem == null
                    ? null
                    : new ItemHeader(_document, _selection.SelectedItem, _selection);
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
                    : new ItemViewModel(_document, _selection.SelectedItem);
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
