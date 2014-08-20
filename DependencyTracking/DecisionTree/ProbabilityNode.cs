using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree
{
    public class ProbabilityNode : INode
    {
        private ObservableList<Path> _paths = new ObservableList<Path>();

        public IEnumerable<Path> Paths
        {
            get { return _paths; }
        }

        public float ExpectedValue
        {
            get { return _paths.Sum(p => p.Weight * p.Child.ExpectedValue); }
        }
    }
}
