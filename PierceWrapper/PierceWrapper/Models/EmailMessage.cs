using Assisticant.Fields;

namespace PierceWrapper.Models
{
    public class EmailMessage : Interaction
    {
        private Observable<bool> _sent = new Observable<bool>(false);

        public bool Sent
        {
            get { return _sent; }
            set { _sent.Value = value; }
        }
    }
}
