using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PierceWrapper.Models;
using PierceWrapper.Views;
using PierceWrapper.ViewModels;
using Assisticant;

namespace PierceWrapper.Services
{
    public class DialogManager
    {
        public void EditContact(Contact contact)
        {
            var dialog = new ContactEditDialog();
            dialog.DataContext = ForView.Wrap(new ContactEditViewModel(contact));

            dialog.ShowDialog();
        }
    }
}
