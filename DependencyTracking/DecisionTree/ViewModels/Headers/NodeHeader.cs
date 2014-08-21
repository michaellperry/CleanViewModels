using DecisionTree.Models.Nodes;
using DecisionTree.Models.Paths;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.ViewModels.Headers
{
    public abstract class NodeHeader
    {
        public abstract IPath Path { get; }

        public string Label
        {
            get { return Path.Child.Label; }
        }

        public string ExpectedValue
        {
            get { return String.Format("{0:#,0.}", Path.Child.ExpectedValue); }
        }

        public Node Node
        {
            get { return Path.Child; }
        }

        public IEnumerable<NodeHeader> Children
        {
            get
            {
                return
                    from child in Path.Child.Paths
                    select NodeHeader.ForPath(child);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            NodeHeader that = obj as NodeHeader;
            if (that == null)
                return false;
            return Object.Equals(this.Path, that.Path);
        }

        public override int GetHashCode()
        {
            return Path.GetHashCode();
        }

        public static NodeHeader ForPath(IPath path)
        {
            return
                Map<Chance>(path, c => new ChanceNodeHeader(c)) ??
                Map<Option>(path, o => new OptionNodeHeader(o)) ??
                Map<Root>  (path, r => new RootNodeHeader(r));
        }

        private static NodeHeader Map<TPath>(IPath path, Func<TPath, NodeHeader> ctor)
            where TPath: class, IPath
        {
            var specificPath = path as TPath;
            if (specificPath != null)
                return ctor(specificPath);
            else
                return null;
        }
    }
}
