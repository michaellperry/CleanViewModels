using DecisionTree.Models.Nodes;

namespace DecisionTree.ViewModels
{
    public class ChoiceNodeViewModel : NodeViewModel
    {
        private readonly ChoiceNode _node;

        public ChoiceNodeViewModel(ChoiceNode node)
        {
            _node = node;
        }

        public override Node Node
        {
            get { return _node; }
        }
    }
}
