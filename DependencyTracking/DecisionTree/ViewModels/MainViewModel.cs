using Assisticant;
using DecisionTree.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace DecisionTree.ViewModels
{
    public class MainViewModel
    {
        private readonly IPath _root;
		private readonly Selection _selection;

        public MainViewModel(IPath root, Selection selection)
        {
            _root = root;
			_selection = selection;
        }

        public IEnumerable<NodeHeader> Nodes
        {
            get
            {
                yield return new NodeHeader(_root);
            }
        }

        public NodeHeader SelectedItem
        {
            get
            {
                return _selection.SelectedPath == null
                    ? null
                    : new NodeHeader(_selection.SelectedPath);
            }
            set
            {
                if (value != null)
                    _selection.SelectedPath = value.Path;
            }
        }
    }
}
