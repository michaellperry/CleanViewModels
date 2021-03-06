﻿using Assisticant.Collections;
using DecisionTree.Models.Paths;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.Models.Nodes
{
    public class ChoiceNode : Node
    {
        private ObservableList<Option> _options = new ObservableList<Option>();

        public ChoiceNode AddOption(float cost, Node child)
        {
            _options.Add(new Option { Cost = cost, Child = child });
            return this;
        }

        public override IEnumerable<Path> Paths
        {
            get { return _options; }
        }

        protected override float ComputeExpectedValue()
        {
            RaiseExpectedValueComputed();
            return _options.Max(o => o.Child.ExpectedValue - o.Cost);
        }
    }
}
