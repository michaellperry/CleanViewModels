using Assisticant.Fields;

namespace DecisionTree.Models
{
    public class Root : IPath
    {
        private Observable<INode> _child = new Observable<INode>(default(INode));

        public INode Child
        {
            get { return _child.Value; }
            set { _child.Value = value; }
        }
    }
}
