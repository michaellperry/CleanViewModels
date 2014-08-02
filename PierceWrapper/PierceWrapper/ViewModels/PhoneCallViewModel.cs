using PierceWrapper.Models;

namespace PierceWrapper.ViewModels
{
    public class PhoneCallViewModel : InteractionViewModel
    {
        private readonly PhoneCall _phoneCall;

        public PhoneCallViewModel(PhoneCall phoneCall)
        {
            _phoneCall = phoneCall;            
        }

        public override Interaction Interaction
        {
            get { return _phoneCall; }
        }

        public bool Outbound
        {
            get { return _phoneCall.Outbound; }
        }
    }
}
