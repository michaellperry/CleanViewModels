using Assisticant;
using DecisionTree.Models;
using System;

namespace DecisionTree.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Root _root;
		private Selection _selection;

        public ViewModelLocator()
        {
			if (DesignMode)
				_root = LoadDesignModeDocument();
			else
				_root = LoadDocument();
			_selection = new Selection();
        }

        public object Main
        {
            get { return ViewModel(() => new MainViewModel(_root, _selection)); }
        }

		public object Item
		{
			get
			{
				return ViewModel(() => _selection.SelectedPath == null
					? null
					: NodeViewModel.ForPath(_selection.SelectedPath));
			}
		}

		private Root LoadDocument()
		{
			// TODO: Load your document here.
            return LoadDesignModeDocument();
		}

		private Root LoadDesignModeDocument()
		{
            var success = new OutcomeNode { Label = "Success" }
                .SetExpectedValue(50000.0f);
            var failure = new OutcomeNode { Label = "Failure" }
                .SetExpectedValue(0.0f);

            var uninformed = new ProbabilityNode()
                .AddChance(0.30f, success)
                .AddChance(0.70f, failure);
            uninformed.Label = "Uninformed";
            var informed = new ProbabilityNode()
                .AddChance(0.60f, success)
                .AddChance(0.40f, failure);
            informed.Label = "Informed";

            var test = new ChoiceNode()
                .AddOption(3000.0f, informed)
                .AddOption(0.0f, uninformed);
            test.Label = "Test";

            return new Root
            {
                Child = test
            };
        }
    }
}
