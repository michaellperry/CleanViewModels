using System;

namespace Cleanliness
{
    public class PersonDetailViewModel
    {
        private readonly PersonSelectionModel _personSelection;

        public PersonDetailViewModel(
          PersonSelectionModel personSelection)
        {
            _personSelection = personSelection;
        }

        public string First
        {
            get
            {
                if (_personSelection.SelectedPerson == null)
                    return null;

                return _personSelection.SelectedPerson.First;
            }
            set
            {
                if (_personSelection.SelectedPerson == null)
                    return;

                _personSelection.SelectedPerson.First = value;
            }
        }

        public string Last
        {
            get
            {
                if (_personSelection.SelectedPerson == null)
                    return null;

                return _personSelection.SelectedPerson.Last;
            }
            set
            {
                if (_personSelection.SelectedPerson == null)
                    return;

                _personSelection.SelectedPerson.Last = value;
            }
        }
    }
}
