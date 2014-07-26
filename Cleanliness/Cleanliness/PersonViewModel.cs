using Assisticant.Fields;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleanliness
{
    public class PersonViewModel : ViewModelBase
    {
        private Observable<string> _first = new Observable<string>();
        private Observable<string> _last = new Observable<string>();

        public string First
        {
            get { return _first; }
            set
            {
                _first.Value = value;
                RaisePropertyChanged(() => First);
                RaisePropertyChanged(() => Full);
            }
        }

        public string Last
        {
            get { return _last; }
            set
            {
                _last.Value = value;
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
