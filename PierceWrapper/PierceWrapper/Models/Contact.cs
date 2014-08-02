using Assisticant.Fields;
using System;

namespace PierceWrapper.Models
{
    public class Contact
    {
        private readonly int _id;

        private Observable<string> _first = new Observable<string>();
        private Observable<string> _last = new Observable<string>();
        private Observable<string> _company = new Observable<string>();
        private Observable<string> _phone = new Observable<string>();
        private Observable<string> _email = new Observable<string>();
        private Observable<DisplayOption> _displayAs = new Observable<DisplayOption>();

        public Contact(int id = -1)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
        }

        public string First
        {
            get { return _first; }
            set { _first.Value = value; }
        }

        public string Last
        {
            get { return _last; }
            set { _last.Value = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company.Value = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone.Value = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email.Value = value; }
        }

        public DisplayOption DisplayAs
        {
            get { return _displayAs; }
            set { _displayAs.Value = value; }
        }

        public string DisplayUsingOption(DisplayOption option)
        {
            if (option == DisplayOption.FirstLast)
                return String.Format("{0} {1}", First, Last);
            else if (option == DisplayOption.LastFirst)
                return String.Format("{0}, {1}", Last, First);
            else if (option == DisplayOption.Company)
                return Company;
            else if (option == DisplayOption.Email)
                return Email;
            else
                throw new ArgumentException(String.Format("Unknown display option {0}.", option));
        }

        public string Display
        {
            get { return DisplayUsingOption(DisplayAs); }
        }
    }
}
