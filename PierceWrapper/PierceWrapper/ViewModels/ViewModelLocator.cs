using Assisticant;
using PierceWrapper.Services;

namespace PierceWrapper.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private ContactRepository _repository = new ContactRepository();
        private DialogManager _dialogManager = new DialogManager();

        public object ContactCard
        {
            get
            {
                return ViewModel(() => new ContactCardViewModel(
                    _repository, _dialogManager, 42));
            }
        }
    }
}
