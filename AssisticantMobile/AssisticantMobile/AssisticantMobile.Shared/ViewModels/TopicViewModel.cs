using Assisticant.Fields;
using AssisticantMobile.Models;
using AssisticantMobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace AssisticantMobile.ViewModels
{
    public class TopicViewModel
    {
        private readonly Topic _topic;
        private readonly ArticleSelection _selection;
        private readonly ILocationService _location;

        private Observable<bool> _busy = new Observable<bool>(default(bool));
        private Observable<Exception> _lastException = new Observable<Exception>(default(Exception));

        public TopicViewModel(
            Topic topic,
            ArticleSelection selection,
            ILocationService location)
        {
            _topic = topic;
            _selection = selection;
            _location = location;
        }

        public async void Load()
        {
            try
            {
                _busy.Value = true;
                await _topic.LoadArticlesAsync();
            }
            catch (Exception ex)
            {
                _lastException.Value = ex;
            }
            finally
            {
                _busy.Value = false;
            }
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

        public bool Busy
        {
            get { return _busy; }
        }
        
        public Exception LastException
        {
            get { return _lastException; }
        }
    }
}
