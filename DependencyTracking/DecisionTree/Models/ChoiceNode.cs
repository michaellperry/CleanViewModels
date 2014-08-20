using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models
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

        public IEnumerable<IPath> Paths
        {
            get { return _options; }
        }
    }
}
