using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models
{
    public class ProbabilityNode : INode
    {
        private ObservableList<Chance> _paths = new ObservableList<Chance>();

        public IEnumerable<Chance> Paths
        {
            get { return _paths; }
        }

        public float ExpectedValue
        {
            get { return _paths.Sum(p => p.Weight * p.Child.ExpectedValue); }
        }

        public IEnumerable<IPath> Paths
        {
            get { return _paths; }
        }
    }
}
