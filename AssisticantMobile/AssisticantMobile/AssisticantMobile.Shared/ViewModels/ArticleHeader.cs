using AssisticantMobile.Models;
using System;

namespace AssisticantMobile.ViewModels
{
    public class ArticleHeader
    {
        private readonly Article _article;

        public ArticleHeader(Article article)
        {
            _article = article;            
        }

        public string Title
        {
            get { return _article.Title; }
        }

        public string Author
        {
            get { return _article.Author; }
        }

        public string Date
        {
            get { return String.Format("{0:d}", _article.Date); }
        }
    }
}
