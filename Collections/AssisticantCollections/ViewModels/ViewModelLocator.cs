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
					: new ItemViewModel(_selection.SelectedItem));
			}
		}

		private Document LoadDocument()
		{
			// TODO: Load your document here.
            Document document = new Document();
            var one = document.NewItem();
            one.Name = "One";
            one.Quantity = 1;
            one.Price = 3.42m;
            var two = document.NewItem();
            two.Name = "Two";
            two.Quantity = 2;
            two.Price = 4.56m;
            var three = document.NewItem();
            three.Name = "Three";
            three.Quantity = 3;
            three.Price = 2.33m;
            return document;
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
            return document;
		}
    }
}
