using Assisticant.Fields;

namespace PierceWrapper.Models
{
    public class ContactSelection
    {
        private Observable<int> _contactId = new Observable<int>(1);

        public int ContactId
        {
            get { return _contactId; }
            set { _contactId.Value = value; }
        }
    }
}
