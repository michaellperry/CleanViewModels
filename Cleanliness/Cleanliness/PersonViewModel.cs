using GalaSoft.MvvmLight;

namespace Cleanliness
{
    public class PersonViewModel : ViewModelBase
    {
        private string _first;
        private string _last;

        public string First
        {
            get { return _first; }
            set
            {
                _first = value;
                RaisePropertyChanged(() => First);
                RaisePropertyChanged(() => Full);
            }
        }

        public string Last
        {
            get { return _last; }
            set
            {
                _last = value;
                RaisePropertyChanged(() => Last);
                RaisePropertyChanged(() => Full);
            }
        }

        public string Full
        {
            get
            {
                return First + " " + Last;
            }
        }
    }
}
