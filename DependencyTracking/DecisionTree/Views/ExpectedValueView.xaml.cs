using Assisticant;
using Assisticant.Fields;
using DecisionTree.ViewModels.Headers;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace DecisionTree.Views
{
    public partial class ExpectedValueView : UserControl
    {
        private Storyboard _updatedStoryboard;

        public ExpectedValueView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            _updatedStoryboard = (Storyboard)FindResource("UpdatedStoryboard");

            ForView.Unwrap<PathHeader>(DataContext, header =>
            {
                header.Node.ExpectedValueComputed += Node_ExpectedValueComputed;
            });
        }

        private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ForView.Unwrap<PathHeader>(DataContext, header =>
            {
                header.Node.ExpectedValueComputed -= Node_ExpectedValueComputed;
            });
        }

        private void Node_ExpectedValueComputed(object sender, System.EventArgs e)
        {
            BeginStoryboard(_updatedStoryboard);
        }
    }
}
