using Assisticant.Fields;
using System;

namespace AssisticantMobile.Models
{
    public class Article
    {
        private Observable<string> _author = new Observable<string>();
        private Observable<string> _title = new Observable<string>();
        private Observable<DateTime> _date = new Observable<DateTime>(DateTime.Now);

        public string Author
        {
            get { return _author; }
            set { _author.Value = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title.Value = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date.Value = value; }
        }
    }
}
