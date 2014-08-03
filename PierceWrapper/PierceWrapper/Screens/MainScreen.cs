using Assisticant;
using PierceWrapper.Models;
using PierceWrapper.Services;
using PierceWrapper.ViewModels;

namespace PierceWrapper.Screens
{
    public class MainScreen
    {
        private readonly ContactRepository _repository;
        private readonly DialogManager _dialogManager;
        private readonly ContactSelection _contactSelection;
        
        public MainScreen(
            ContactRepository repository,
            DialogManager dialogManager,
            ContactSelection contactSelection)
        {
            _repository = repository;
            _dialogManager = dialogManager;
            _contactSelection = contactSelection;
        }

        public object Content
        {
            get
            {
                return ForView.Wrap(new ContactCardViewModel(
                    _repository,
                    _dialogManager,
                    _contactSelection.ContactId));
            }
        }
    }
}
