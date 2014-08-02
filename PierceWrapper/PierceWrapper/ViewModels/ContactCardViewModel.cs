using Assisticant.Fields;
using PierceWrapper.Models;
using PierceWrapper.Services;

namespace PierceWrapper.ViewModels
{
    public class ContactCardViewModel
    {
        private readonly ContactRepository _repository;
        private readonly DialogManager _dialogManager;
        private readonly int _contactId;

        private Observable<Contact> _contact = new Observable<Contact>(
            new Contact());
        
        public ContactCardViewModel(
            ContactRepository repository,
            DialogManager dialogManager,
            int contactId)
        {
            _repository = repository;
            _dialogManager = dialogManager;
            _contactId = contactId;
        }

        public void Load()
        {
            _contact.Value = _repository.LoadContact(_contactId);
        }

        public string Display
        {
            get { return _contact.Value.Display; }
        }

        public string First
        {
            get { return _contact.Value.First; }
        }

        public string Last
        {
            get { return _contact.Value.Last; }
        }

        public string Company
        {
            get { return _contact.Value.Company; }
        }

        public string Phone
        {
            get { return _contact.Value.Phone; }
        }

        public string Email
        {
            get { return _contact.Value.Email; }
        }

        public bool CanEdit
        {
            get { return _contact.Value.Id != -1; }
        }

        public void Edit()
        {
            _dialogManager.EditContact(_contact);
        }
    }
}
