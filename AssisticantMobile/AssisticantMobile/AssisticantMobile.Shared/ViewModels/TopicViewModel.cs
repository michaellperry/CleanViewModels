using Assisticant.Fields;
using AssisticantMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AssisticantMobile.ViewModels
{
    public class TopicViewModel
    {
        private readonly Topic _topic;

        public TopicViewModel(Topic topic)
        {
            _topic = topic;
        }

        public void Load()
        {
        }

        public string Name
        {
            get { return _topic.Name; }
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
    }
}
