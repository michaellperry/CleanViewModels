using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Option
    {
        private Observable<INode> _child = new Observable<INode>(default(INode));
        private Observable<float> _cost = new Observable<float>(default(float));

        public INode Child
        {
            get { return _child.Value; }
            set { _child.Value = value; }
        }

        public float Cost
        {
            get { return _cost; }
            set { _cost.Value = value; }
        }
    }
}
