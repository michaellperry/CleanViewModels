using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models
{
    public class ChoiceNode : INode
    {
        private ObservableList<Option> _options = new ObservableList<Option>();

        public ChoiceNode AddOption(float cost, INode child)
        {
            _options.Add(new Option { Cost = cost, Child = child });
            return this;
        }

        public float ExpectedValue
        {
            get { return _options.Max(o => o.Child.ExpectedValue - o.Cost); }
        }

        public IEnumerable<IPath> Paths
        {
            get { return _options; }
        }
    }
}
