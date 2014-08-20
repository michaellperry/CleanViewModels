using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.App.ViewModels
{
    public class NodeHeader
    {
        private readonly INode _node;

        public NodeHeader(INode node)
        {
            _node = node;
        }

        public INode Node
        {
            get { return _node; }
        }

        public string ExpectedValue
        {
            get { return String.Format("{0:0.00}", _node.ExpectedValue); }
        }

        public IEnumerable<NodeHeader> Children
        {
            get
            {
                return
                    from child in _node.Children
                    select new NodeHeader(child);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            NodeHeader that = obj as NodeHeader;
            if (that == null)
                return false;
            return Object.Equals(this._node, that._node);
        }

        public override int GetHashCode()
        {
            return _node.GetHashCode();
        }
    }
}
