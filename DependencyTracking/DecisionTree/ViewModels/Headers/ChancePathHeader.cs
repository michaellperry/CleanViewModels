using DecisionTree.Models.Paths;
using System;

namespace DecisionTree.ViewModels.Headers
{
    public class ChancePathHeader : PathHeader
    {
        private readonly Chance _chance;

        public ChancePathHeader(Chance chance)
        {
            _chance = chance;
        }

        public override Path Path
        {
            get { return _chance; }
        }

        public string Weight
        {
            get { return String.Format("{0}%", _chance.Weight * 100.0f); }
        }
    }
}
