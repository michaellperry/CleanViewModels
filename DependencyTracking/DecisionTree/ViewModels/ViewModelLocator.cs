using Assisticant;
using DecisionTree.Models;
using System;

namespace DecisionTree.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Root _root;
		private Selection _selection;

        public ViewModelLocator()
        {
			if (DesignMode)
				_root = LoadDesignModeDocument();
			else
				_root = LoadDocument();
			_selection = new Selection();
        }

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(_root, _selection)); }
        }

		public object Item
		{
			get
			{
				return ViewModel(() => _selection.SelectedPath == null
					? null
					: NodeViewModel.ForPath(_selection.SelectedPath));
			}
		}

		private Root LoadDocument()
		{
			// TODO: Load your document here.
            throw new NotImplementedException();
		}

		private Root LoadDesignModeDocument()
		{
            throw new NotImplementedException();
        }
    }
}
