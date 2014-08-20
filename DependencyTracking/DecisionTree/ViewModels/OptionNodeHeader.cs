using DecisionTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTree.ViewModels
{
    public class OptionNodeHeader : NodeHeader
    {
        private readonly Option _option;

        public OptionNodeHeader(Option option)
        {
            _option = option;            
        }

        public override IPath Path
        {
            get { return _option; }
        }

        public string Cost
        {
            get { return String.Format("{0:#,0}", _option.Cost); }
        }
    }
}
