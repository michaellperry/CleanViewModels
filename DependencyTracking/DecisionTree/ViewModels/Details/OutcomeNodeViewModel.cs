using DecisionTree.Models.Nodes;

namespace DecisionTree.ViewModels.Details
{
    public class OutcomeNodeViewModel : NodeViewModel
    {
        private readonly OutcomeNode _node;

        public OutcomeNodeViewModel(OutcomeNode node)
        {
            _node = node;
        }

        public float Value
        {
            get { return _node.Value; }
            set { _node.Value = value; }
        }

        public override Node Node
        {
            get { return _node; }
        }
    }
}
