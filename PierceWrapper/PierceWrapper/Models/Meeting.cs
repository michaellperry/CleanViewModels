using Assisticant.Fields;

namespace PierceWrapper.Models
{
    public class Meeting : Interaction
    {
        private Observable<string> _location = new Observable<string>();

        public string Location
        {
            get { return _location; }
            set { _location.Value = value; }
        }
    }
}
