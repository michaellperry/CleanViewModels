using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assisticant.XAML;
using AssisticantBasics.Models;

namespace AssisticantBasics.ViewModels
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

        public object Summary
        {
            get
            {
                return ViewModel(() =>
                    new SummaryViewModel(_document));
            }
        }

		private Document LoadDocument()
		{
			// TODO: Load your document here.
            Document document = new Document();
            var one = document.NewItem();
            one.Name = "One";
            var two = document.NewItem();
            two.Name = "Two";
            var three = document.NewItem();
            three.Name = "Three";
            return document;
		}

		private Document LoadDesignModeDocument()
		{
            Document document = new Document();
            var one = document.NewItem();
            one.Name = "Design";
            var two = document.NewItem();
            two.Name = "Mode";
            var three = document.NewItem();
            three.Name = "Data";
            return document;
		}
    }
}
