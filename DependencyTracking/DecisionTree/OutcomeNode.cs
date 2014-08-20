using Assisticant.Fields;

namespace DecisionTree
{
    public class OutcomeNode : INode
    {
        private Observable<float> _expectedValue = new Observable<float>(default(float));

        public float ExpectedValue
        {
            get { return _expectedValue; }
            set { _expectedValue.Value = value; }
        }
    }
}
