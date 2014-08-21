using DecisionTree.Models.Nodes;
using DecisionTree.Models.Paths;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.ViewModels.Headers
{
    public abstract class PathHeader
    {
        public abstract Path Path { get; }

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

        public IEnumerable<PathHeader> Children
        {
            get
            {
                return
                    from child in Path.Child.Paths
                    select PathHeader.ForPath(child);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            PathHeader that = obj as PathHeader;
            if (that == null)
                return false;
            return Object.Equals(this.Path, that.Path);
        }

        public override int GetHashCode()
        {
            return Path.GetHashCode();
        }

        public static PathHeader ForPath(Path path)
        {
            return
                Map<Chance>(path, c => new ChancePathHeader(c)) ??
                Map<Option>(path, o => new OptionPathHeader(o)) ??
                Map<Root>  (path, r => new RootPathHeader(r));
        }

        private static PathHeader Map<TPath>(Path path, Func<TPath, PathHeader> ctor)
            where TPath: Path
        {
            var specificPath = path as TPath;
            if (specificPath != null)
                return ctor(specificPath);
            else
                return null;
        }
    }
}
