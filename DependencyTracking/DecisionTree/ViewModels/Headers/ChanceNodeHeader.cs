using DecisionTree.Models.Paths;
using System;

namespace DecisionTree.ViewModels.Headers
{
    public class ChanceNodeHeader : NodeHeader
    {
        private readonly Chance _chance;

        public ChanceNodeHeader(Chance chance)
        {
            _chance = chance;
        }

        public override IPath Path
        {
            get { return _chance; }
        }

        public string Weight
        {
            get { return String.Format("{0}%", _chance.Weight * 100.0f); }
        }
    }
}
