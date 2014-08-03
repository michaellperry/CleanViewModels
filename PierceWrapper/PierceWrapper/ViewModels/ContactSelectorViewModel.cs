using PierceWrapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierceWrapper.ViewModels
{
    public class ContactSelectorViewModel
    {
        private readonly ContactSelection _selection;

        public ContactSelectorViewModel(ContactSelection selection)
        {
            _selection = selection;
        }

        public void Next()
        {
            _selection.ContactId++;
        }

        public void Previous()
        {
            _selection.ContactId--;
        }
    }
}
