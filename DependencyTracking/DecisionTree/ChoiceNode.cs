using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree
{
    public class ChoiceNode : INode
    {
        private ObservableList<INode> _options = new ObservableList<INode>();

        public IEnumerable<INode> Options
        {
            get { return _options; }
        }

        public float ExpectedValue
        {
            get { return _options.Max(o => o.ExpectedValue); }
        }
    }
}
