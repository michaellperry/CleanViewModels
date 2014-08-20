using System;

namespace DecisionTree.App.ViewModels
{
    public abstract class NodeViewModel
    {
        public abstract INode Node { get; }

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
    }
}
