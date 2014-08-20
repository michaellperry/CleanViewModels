using DecisionTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.ViewModels
{
    public class NodeHeader
    {
        private readonly IPath _path;

        public NodeHeader(IPath path)
        {
            _path = path;
        }

        public IPath Path
        {
            get { return _path; }
        }

        public string ExpectedValue
        {
            get { return String.Format("{0:0.00}", _path.Child.ExpectedValue); }
        }

        public IEnumerable<NodeHeader> Children
        {
            get
            {
                return
                    from child in _path.Child.Paths
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
            return Object.Equals(this._path, that._path);
        }

        public override int GetHashCode()
        {
            return _path.GetHashCode();
        }
    }
}
