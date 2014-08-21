using DecisionTree.Models;
using DecisionTree.Models.Paths;
using DecisionTree.ViewModels.Headers;
using System.Collections.Generic;

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
                yield return NodeHeader.ForPath(_root);
            }
        }

        public NodeHeader SelectedItem
        {
            get
            {
                return _selection.SelectedPath == null
                    ? null
                    : NodeHeader.ForPath(_selection.SelectedPath);
            }
            set
            {
                if (value != null)
                    _selection.SelectedPath = value.Path;
            }
        }
    }
}
