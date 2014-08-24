using Assisticant.Fields;
using DecisionTree.Models.Paths;
using System.Collections.Generic;

namespace DecisionTree.Models.Nodes
{
    public class OutcomeNode : Node
    {
        private Observable<float> _value = new Observable<float>(default(float));

        public float Value
        {
            get { return _value; }
            set { _value.Value = value; }
        }

        public override IEnumerable<Path> Paths
        {
            get { yield break; }
        }

        protected override float ComputeExpectedValue()
        {
            RaiseExpectedValueComputed();
            return _value;
        }
    }
}
