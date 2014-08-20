using DecisionTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionTree.ViewModels
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
    }
}
