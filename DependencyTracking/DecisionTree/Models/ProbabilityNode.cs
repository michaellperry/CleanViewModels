using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models
{
    public class ProbabilityNode : INode
    {
        private ObservableList<Chance> _chances = new ObservableList<Chance>();

        public IEnumerable<Chance> Chances
        {
            get { return _chances; }
        }

        public float ExpectedValue
        {
            get { return _chances.Sum(p => p.Weight * p.Child.ExpectedValue); }
        }

        public IEnumerable<IPath> Paths
        {
            get { return _chances; }
        }
    }
}
