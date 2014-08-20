using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree
{
    public class ChoiceNode : INode
    {
        private ObservableList<Option> _options = new ObservableList<Option>();

        public IEnumerable<Option> Options
        {
            get { return _options; }
        }

        public float ExpectedValue
        {
            get { return _options.Max(o => o.Child.ExpectedValue - o.Cost); }
        }

        public IEnumerable<INode> Children
        {
            get { return _options.Select(o => o.Child); }
        }
    }
}
