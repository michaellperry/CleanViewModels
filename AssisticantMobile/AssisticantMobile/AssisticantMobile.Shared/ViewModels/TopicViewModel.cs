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
        private readonly ArticleSelection _selection;
        
        public TopicViewModel(Topic topic, ArticleSelection selection)
        {
            _topic = topic;
            _selection = selection;
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
