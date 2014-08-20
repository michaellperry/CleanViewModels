using DecisionTree.Models;

namespace DecisionTree.ViewModels
{
    public class ChoiceNodeViewModel : NodeViewModel
    {
        private readonly ChoiceNode _node;

        public ChoiceNodeViewModel(ChoiceNode node)
        {
            _node = node;
        }

        public override INode Node
        {
            get { return _node; }
        }
    }
}
