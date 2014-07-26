using Assisticant.Fields;

namespace Cleanliness
{
    public class PersonSelectionModel
    {
        private Observable<Person> _selectedPerson =
          new Observable<Person>();

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson.Value = value; }
        }
    }
}
