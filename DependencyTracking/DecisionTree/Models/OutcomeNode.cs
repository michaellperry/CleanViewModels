﻿using Assisticant.Fields;
using System.Collections.Generic;

namespace DecisionTree.Models
{
    public class OutcomeNode : Node
    {
        private Observable<float> _expectedValue = new Observable<float>(default(float));

        public override float ExpectedValue
        {
            get { return _expectedValue; }
        }

        public OutcomeNode SetExpectedValue(float value)
        {
            _expectedValue.Value = value;
            return this;
        }

        public override IEnumerable<IPath> Paths
        {
            get { yield break; }
        }
    }
}
