using Assisticant.Fields;
using System;

namespace PierceWrapper.Models
{
    public abstract class Interaction
    {
        private Observable<DateTime> _date = new Observable<DateTime>(DateTime.Now);

        public DateTime Date
        {
            get { return _date; }
            set { _date.Value = value; }
        }
    }
}
