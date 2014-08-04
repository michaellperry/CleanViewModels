using Assisticant;
using AssisticantMobile.Models;
using AssisticantMobile.Services;

namespace AssisticantMobile.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Topic _topic;
        private ArticleSelection _articleSelection;
        private TileUpdater _tileUpdater;
        private GpsLocationService _location;

        public ViewModelLocator()
        {
            _topic = new Topic
            {
                Name = "Information Theory"
            };
            _articleSelection = new ArticleSelection();
            _tileUpdater = new TileUpdater(_articleSelection);
            _location = new GpsLocationService();
        }

        public object Topic
        {
            get
            {
                return ViewModel(() => new TopicViewModel(
                    _topic,
                    _articleSelection,
                    _location));
            }
        }
    }
}
