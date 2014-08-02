using PierceWrapper.Models;

namespace PierceWrapper.Services
{
    public class ContactRepository
    {
        public Contact LoadContact(int contactId)
        {
            return new Contact(contactId)
            {
                First = "Jose",
                Last = "Capablanca",
                Email = "champion@fide.org",
                Phone = "555-1911",
                DisplayAs = DisplayOption.LastFirst
            };
        }
    }
}
