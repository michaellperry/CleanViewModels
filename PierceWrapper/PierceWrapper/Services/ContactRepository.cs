using PierceWrapper.Models;
using System;

namespace PierceWrapper.Services
{
    public class ContactRepository
    {
        public Contact LoadContact(int contactId)
        {
            Contact newContact = new Contact(contactId)
            {
                First = "Jose",
                Last = "Capablanca",
                Company = "Columbia University",
                Email = "champion@fide.org",
                Phone = "555-1911",
                DisplayAs = DisplayOption.LastFirst
            };
            newContact.AddIneraction(new Meeting
            {
                Date = new DateTime(1911, 3, 17),
                Location = "Hastings"
            });
            newContact.AddIneraction(new PhoneCall
            {
                Date = new DateTime(1913, 5, 10),
                Outbound = true
            });
            newContact.AddIneraction(new EmailMessage
            {
                Date = new DateTime(1914, 7, 3),
                Sent = true
            });
            return newContact;
        }
    }
}
