using Assisticant.Fields;

namespace PierceWrapper.Models
{
    public class PhoneCall : Interaction
    {
        private Observable<bool> _outbound = new Observable<bool>(false);

        public bool Outbound
        {
            get { return _outbound; }
            set { _outbound.Value = value; }
        }
    }
}
