using DecisionTree.Models;
using System;

namespace DecisionTree.ViewModels
{
    public abstract class NodeViewModel
    {
        public abstract Node Node { get; }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            NodeViewModel that = obj as NodeViewModel;
            if (that == null)
                return false;
            return Object.Equals(this.Node, that.Node);
        }

        public override int GetHashCode()
        {
            return Node.GetHashCode();
        }

        public static NodeViewModel ForPath(IPath path)
        {
            throw new NotImplementedException();
        }
    }
}
