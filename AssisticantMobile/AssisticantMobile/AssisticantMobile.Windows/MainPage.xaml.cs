using Assisticant;
using AssisticantMobile.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AssisticantMobile
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ForView.Unwrap<TopicViewModel>(DataContext, vm =>
                vm.Load());
        }
    }
}
