using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Option : IPath
    {
        private Observable<float> _cost = new Observable<float>(default(float));
        private Observable<INode> _child = new Observable<INode>(default(INode));

        public float Cost
        {
            get { return _cost; }
            set { _cost.Value = value; }
        }

        public INode Child
        {
            get { return _child.Value; }
            set { _child.Value = value; }
        }
    }
}
