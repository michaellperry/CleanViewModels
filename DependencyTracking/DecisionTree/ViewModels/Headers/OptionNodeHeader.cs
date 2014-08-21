using DecisionTree.Models.Paths;
using System;

namespace DecisionTree.ViewModels.Headers
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
