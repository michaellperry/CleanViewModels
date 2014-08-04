using Assisticant.Fields;
using AssisticantMobile.Models;
using AssisticantMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Devices.Geolocation;

namespace AssisticantMobile.ViewModels
{
    public class TopicViewModel : AsynchronousViewModel
    {
        private readonly Topic _topic;
        private readonly ArticleSelection _selection;
        private readonly ILocationService _location;

        private Computed<Geocoordinate> _coordinate;

        public TopicViewModel(
            Topic topic,
            ArticleSelection selection,
            ILocationService location)
        {
            _topic = topic;
            _selection = selection;
            _location = location;

            _coordinate = new Computed<Geocoordinate>(
                () => _location.Coordinate);
            _coordinate.Subscribe(
                c => FindPeopleByLocation(c));
        }

        public void Load()
        {
            Perform(async delegate
            {
                await _topic.LoadArticlesAsync();
            });
        }

        private void FindPeopleByLocation(Geocoordinate coordinate)
        {
            Perform(async delegate
            {
                await _topic.FindPeopleByLocationAsync(coordinate);
            });
        }

        public string Name
        {
            get { return _topic.Name; }
        }

        public string Location
        {
            get
            {
                var coordinate = _location.Coordinate;
                return coordinate == null
                    ? null
                    : String.Format("{0}, {1}", coordinate.Latitude, coordinate.Longitude);
            }
        }

        public IEnumerable<ArticleHeader> Articles
        {
            get
            {
                return
                    from article in _topic.Articles
                    orderby article.Date
                    select new ArticleHeader(article);
            }
        }

        public ArticleHeader SelectedArticle
        {
            get
            {
                return _selection.SelectedArticle == null
                    ? null
                    : new ArticleHeader(_selection.SelectedArticle);
            }
            set
            {
                _selection.SelectedArticle = value == null
                    ? null
                    : value.Article;
            }
        }
    }
}
