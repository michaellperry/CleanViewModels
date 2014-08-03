using Assisticant.Fields;

namespace AssisticantMobile.Models
{
    public class ArticleSelection
    {
        private Observable<Article> _selectedArticle = new Observable<Article>();

        public Article SelectedArticle
        {
            get { return _selectedArticle; }
            set { _selectedArticle.Value = value; }
        }
    }
}
