using Assisticant;
using PierceWrapper.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PierceWrapper.ViewModels
{
    public class ContactEditViewModel
    {
        private readonly Contact _contact;

        public ContactEditViewModel(Contact contact)
        {
            _contact = contact;
        }

        public string Display
        {
            get { return _contact.Display; }
        }

        public string First
        {
            get { return _contact.First; }
            set { _contact.First = value; }
        }

        public string Last
        {
            get { return _contact.Last; }
            set { _contact.Last = value; }
        }

        public string Company
        {
            get { return _contact.Company; }
            set { _contact.Company = value; }
        }

        public string Phone
        {
            get { return _contact.Phone; }
            set { _contact.Phone = value; }
        }

        public string Email
        {
            get { return _contact.Email; }
            set { _contact.Email = value; }
        }

        public IEnumerable<DisplayViewModel> DisplayAsOptions
        {
            get
            {
                return
                    from displayOption in Enum
                        .GetValues(typeof(DisplayOption))
                        .OfType<DisplayOption>()
                    select new DisplayViewModel(_contact, displayOption);
            }
        }

        public DisplayViewModel DisplayAs
        {
            get
            {
                return new DisplayViewModel(_contact, _contact.DisplayAs);
            }
            set
            {
                _contact.DisplayAs = value.DisplayOption;
            }
        }
    }
}
