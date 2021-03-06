﻿using Assisticant.Collections;
using Assisticant.Fields;
using System;
using System.Collections.Generic;

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
        private ObservableList<Interaction> _interactions = new ObservableList<Interaction>();

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

        public IEnumerable<Interaction> Interactions
        {
            get { return _interactions; }
        }

        public void AddIneraction(Interaction interaction)
        {
            _interactions.Add(interaction);
        }

        public static Contact Copy(Contact original)
        {
            var copy = new Contact(original.Id);
            original.CopyTo(copy);
            return copy;
        }

        public void CopyTo(Contact destination)
        {
            destination.First = First;
            destination.Last = Last;
            destination.Company = Company;
            destination.Email = Email;
            destination.Phone = Phone;
            destination.DisplayAs = DisplayAs;
        }
    }
}
