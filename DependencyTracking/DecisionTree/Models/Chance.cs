using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Chance : IPath
    {
        private Observable<float> _weight = new Observable<float>();
        private Observable<INode> _child = new Observable<INode>();

        public float Weight
        {
            get { return _weight; }
            set { _weight.Value = value; }
        }

        public INode Child
        {
            get { return _child.Value; }
            set { _child.Value = value; }
        }
    }
}
