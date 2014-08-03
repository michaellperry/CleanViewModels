using Assisticant.Collections;
using Assisticant.Fields;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssisticantMobile.Models
{
    public class Topic
    {
        private Observable<string> _name = new Observable<string>(default(string));
        private ObservableList<Article> _articles = new ObservableList<Article>();

        public string Name
        {
            get { return _name; }
            set { _name.Value = value; }
        }

        public IEnumerable<Article> Articles
        {
            get { return _articles; }
        }

        public async Task LoadArticlesAsync()
        {
            await Task.Delay(2000);

            lock (this)
            {
                _articles.Add(new Article
                {
                    Author = "Jaynes, E. T.",
                    Title = "Information Theory and Statistical Mechanics",
                    Date = new DateTime(1957, 5, 10)
                });
                _articles.Add(new Article
                {
                    Author = "Reza, Fazlollah M.",
                    Title = "An Introduction to Information Theory",
                    Date = new DateTime(1961, 3, 14)
                });
                _articles.Add(new Article
                {
                    Author = "Gibson, Jerry D.",
                    Title = "Digital Compression for Multimedia: Principles and Standards",
                    Date = new DateTime(1998, 12, 3)
                });
            }
        }
    }
}
