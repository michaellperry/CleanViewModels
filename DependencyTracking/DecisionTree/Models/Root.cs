using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Root : IPath
    {
        private Observable<Node> _child = new Observable<Node>();

        public Node Child
        {
            get { return _child; }
            set { _child.Value = value; }
        }
    }
}
