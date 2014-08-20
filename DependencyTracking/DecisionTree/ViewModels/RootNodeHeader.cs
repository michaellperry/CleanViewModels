using DecisionTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTree.ViewModels
{
    public class RootNodeHeader : NodeHeader
    {
        private readonly Root _root;

        public RootNodeHeader(Root root)
        {
            _root = root;            
        }

        public override IPath Path
        {
            get { return _root; }
        }
    }
}
