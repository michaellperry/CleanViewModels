using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssisticantCollections.Models;
using Assisticant;

namespace AssisticantCollections.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Document _document;
		private Selection _selection;

        public ViewModelLocator()
        {
			if (DesignMode)
				_document = LoadDesignModeDocument();
			else
				_document = LoadDocument();
			_selection = new Selection();
            if (DesignMode)
                _selection.SelectedItem = _document.Items.First();
        }

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(_document, _selection)); }
        }

		public object Item
		{
			get
			{
				return ViewModel(() => _selection.SelectedItem == null
					? null
					: new ItemViewModel(_document, _selection.SelectedItem));
			}
		}

		private Document LoadDocument()
		{
			// TODO: Load your document here.
            Document document = new Document();

            NewParentItem(document, "One", 1, 3.42m);
            NewParentItem(document, "Two", 2, 4.56m);
            NewParentItem(document, "Three", 3, 2.33m);

            return document;
		}

        private static Item NewParentItem(Document document, string name, int quantity, decimal price)
        {
            var parent = document.NewItem();
            parent.Name = name;
            parent.Quantity = quantity;
            parent.Price = price;

            //NewChildItem(document, parent, "-a", 7);
            //NewChildItem(document, parent, "-b", 13);
            //NewChildItem(document, parent, "-c", 27);

            return parent;
        }

        private static void NewChildItem(Document document, Item parent, string sub, int multiplier)
        {
            var childA = document.NewItem();
            childA.Name = parent.Name + sub;
            childA.Quantity = parent.Quantity * multiplier;
            childA.Price = parent.Price * multiplier;
            childA.Parent = parent;
        }

        private Document LoadDesignModeDocument()
		{
            Document document = new Document();
            var one = document.NewItem();
            one.Name = "Design";
            one.Quantity = 1;
            one.Price = 1.11m;
            var two = document.NewItem();
            two.Name = "Mode";
            two.Quantity = 2;
            two.Price = 2.22m;
            var three = document.NewItem();
            three.Name = "Data";
            three.Quantity = 3;
            three.Price = 3.33m;

            one.Parent = two;

            return document;
		}
    }
}
