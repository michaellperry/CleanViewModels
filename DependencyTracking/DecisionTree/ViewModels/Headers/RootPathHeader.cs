using DecisionTree.Models.Paths;

namespace DecisionTree.ViewModels.Headers
{
    public class RootPathHeader : PathHeader
    {
        private readonly Root _root;

        public RootPathHeader(Root root)
        {
            _root = root;            
        }

        public override Path Path
        {
            get { return _root; }
        }
    }
}
