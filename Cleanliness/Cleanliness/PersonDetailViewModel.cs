using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanliness
{
    public class PersonDetailViewModel : ViewModelBase
    {
        private Directory _directory;
        private int _id;
        private string _first;
        private string _last;

        public PersonDetailViewModel()
        {
            _directory = new Directory();
            MessengerInstance.Register<PersonSelected>(this, message =>
            {
                var person = _directory.LoadPerson(message.PersonId);
                _id = message.PersonId;
                First = person.First;
                Last = person.Last;
            });
        }

        public string First
        {
            get { return _first; }
            set
            {
                if (value == _first)
                    return;

                _first = value;
                RaisePropertyChanged(() => this.First);

                MessengerInstance.Send(new PersonNameChanged
                {
                    PersonId = _id,
                    First = value,
                    Last = Last
                });
            }
        }

        public string Last
        {
            get { return _last; }
            set
            {
                if (value == _last)
                    return;

                _last = value;
                RaisePropertyChanged(() => this.Last);

                MessengerInstance.Send(new PersonNameChanged
                {
                    PersonId = _id,
                    First = First,
                    Last = value
                });
            }
        }
    }
}
