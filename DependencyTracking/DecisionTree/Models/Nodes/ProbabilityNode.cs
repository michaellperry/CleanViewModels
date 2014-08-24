using Assisticant.Collections;
using DecisionTree.Models.Paths;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models.Nodes
{
    public class ProbabilityNode : Node
    {
        private ObservableList<Chance> _chances = new ObservableList<Chance>();

        public ProbabilityNode AddChance(float weight, Node child)
        {
            _chances.Add(new Chance
            {
                Weight = weight,
                Child = child
            });
            return this;
        }

        public override IEnumerable<Path> Paths
        {
            get { return _chances; }
        }

        protected override float ComputeExpectedValue()
        {
            RaiseExpectedValueComputed();
            return _chances.Sum(p => p.Weight * p.Child.ExpectedValue);
        }
    }
}
