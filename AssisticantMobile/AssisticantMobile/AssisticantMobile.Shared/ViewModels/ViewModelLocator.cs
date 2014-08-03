using Assisticant;
using AssisticantMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssisticantMobile.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private Topic _topic;
        private ArticleSelection _articleSelection;
        private TileUpdater _tileUpdater;

        public ViewModelLocator()
        {
            _topic = new Topic
            {
                Name = "Information Theory"
            };
            _articleSelection = new ArticleSelection();
            _tileUpdater = new TileUpdater(_articleSelection);
        }

        public object Topic
        {
            get
            {
                return ViewModel(() => new TopicViewModel(_topic, _articleSelection));
            }
        }
    }
}
