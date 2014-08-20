using Assisticant.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models
{
    public class ProbabilityNode : INode
    {
        private ObservableList<Chance> _chances = new ObservableList<Chance>();

        public ProbabilityNode AddChance(float weight, INode child)
        {
            _chances.Add(new Chance
            {
                Weight = weight,
                Child = child
            });
            return this;
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
