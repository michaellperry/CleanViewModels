using DecisionTree.Models.Paths;

namespace DecisionTree.ViewModels.Headers
{
    public class RootNodeHeader : NodeHeader
    {
        private readonly Root _root;

        public RootNodeHeader(Root root)
        {
            _root = root;            
        }

        public override IPath Path
        {
            get { return _root; }
        }
    }
}
