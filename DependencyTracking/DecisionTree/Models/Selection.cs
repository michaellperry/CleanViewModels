using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Selection
    {
        private Observable<INode> _selectedNode = new Observable<INode>(default(INode));

        public INode SelectedNode
        {
            get { return _selectedNode.Value; }
            set { _selectedNode.Value = value; }
        }
    }
}
