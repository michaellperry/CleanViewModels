using Assisticant;
using DecisionTree.Models;
using System;

namespace DecisionTree.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private INode _root;
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
				return ViewModel(() => _selection.SelectedNode == null
					? null
					: NodeViewModel.ForNode(_selection.SelectedNode));
			}
		}

		private INode LoadDocument()
		{
			// TODO: Load your document here.
            throw new NotImplementedException();
		}

		private INode LoadDesignModeDocument()
		{
            throw new NotImplementedException();
        }
    }
}
