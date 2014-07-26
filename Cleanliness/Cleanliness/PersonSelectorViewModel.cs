using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanliness
{
    public class PersonSelectorViewModel : ViewModelBase
    {
        private readonly Directory _directory;
        private readonly List<Person> _people;
        private Person _selectedPerson = null;

        public PersonSelectorViewModel(
          Directory directory)
        {
            _directory = directory;

            _people = _directory.GetPeople();

            MessengerInstance.Register<PersonNameChanged>(this, message =>
            {
                var person = _people.FirstOrDefault(p => p.Id == message.PersonId);
                if (person != null)
                {
                    person.First = message.First;
                    person.Last = message.Last;
                }
            });
        }

        public IEnumerable<Person> People
        {
            get { return _people; }
        }

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if (_selectedPerson == value)
                    return;

                _selectedPerson = value;
                RaisePropertyChanged(() => this.SelectedPerson);

                MessengerInstance.Send(new PersonSelected
                {
                    PersonId = value.Id
                });
            }
        }
    }
}
