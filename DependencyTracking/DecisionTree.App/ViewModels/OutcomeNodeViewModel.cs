
namespace DecisionTree.App.ViewModels
{
    public class OutcomeNodeViewModel : NodeViewModel
    {
        private readonly OutcomeNode _node;

        public OutcomeNodeViewModel(OutcomeNode node)
        {
            _node = node;
        }

        public float ExpectedValue
        {
            get { return _node.ExpectedValue; }
            set { _node.ExpectedValue = value; }
        }

        public override INode Node
        {
            get { return _node; }
        }
    }
}
