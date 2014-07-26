using System.Collections.Generic;

namespace Cleanliness
{
    public class PersonSelectorViewModel
    {
        private readonly Directory _directory;
        private readonly List<Person> _people;
        private readonly PersonSelectionModel _personSelection;

        public PersonSelectorViewModel(
          Directory directory,
          PersonSelectionModel personSelection)
        {
            _directory = directory;
            _personSelection = personSelection;

            _people = _directory.GetPeople();
        }

        public IEnumerable<Person> People
        {
            get { return _people; }
        }

        public Person SelectedPerson
        {
            get { return _personSelection.SelectedPerson; }
            set { _personSelection.SelectedPerson = value; }
        }
    }
}
