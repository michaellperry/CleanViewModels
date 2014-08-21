using Assisticant.Fields;
using DecisionTree.Models.Nodes;

namespace DecisionTree.Models.Paths
{
    public class Chance : IPath
    {
        private Observable<float> _weight = new Observable<float>();
        private Observable<Node> _child = new Observable<Node>();

        public float Weight
        {
            get { return _weight; }
            set { _weight.Value = value; }
        }

        public Node Child
        {
            get { return _child; }
            set { _child.Value = value; }
        }
    }
}
