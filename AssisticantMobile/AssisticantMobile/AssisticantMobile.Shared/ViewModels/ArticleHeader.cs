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

        public Article Article
        {
            get { return _article; }
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

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            var that = obj as ArticleHeader;
            if (that == null)
                return false;

            return Object.Equals(this._article, that._article);
        }

        public override int GetHashCode()
        {
            return _article.GetHashCode();
        }
    }
}
