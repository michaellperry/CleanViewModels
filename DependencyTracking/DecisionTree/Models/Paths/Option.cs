using Assisticant.Fields;
using DecisionTree.Models.Nodes;

namespace DecisionTree.Models.Paths
{
    public class Option : IPath
    {
        private Observable<float> _cost = new Observable<float>();
        private Observable<Node> _child = new Observable<Node>();

        public float Cost
        {
            get { return _cost; }
            set { _cost.Value = value; }
        }

        public Node Child
        {
            get { return _child; }
            set { _child.Value = value; }
        }
    }
}
