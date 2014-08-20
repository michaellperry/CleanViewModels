using Assisticant.Fields;
using System.Collections.Generic;

namespace DecisionTree.Models
{
    public class OutcomeNode : INode
    {
        private Observable<float> _expectedValue = new Observable<float>(default(float));

        public float ExpectedValue
        {
            get { return _expectedValue; }
            set { _expectedValue.Value = value; }
        }

        public IEnumerable<IPath> Children
        {
            get { yield break; }
        }
    }
}
