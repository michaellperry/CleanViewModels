using PierceWrapper.Models;
using System;

namespace PierceWrapper.Services
{
    public class ContactRepository
    {
        public Contact LoadContact(int contactId)
        {
            if (contactId == 1)
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
            else if (contactId == 2)
            {
                Contact newContact = new Contact(contactId)
                {
                    First = "Garry",
                    Last = "Kasparov",
                    Company = "Democratic Party of Russia",
                    Email = "kasparov@democrats.ru",
                    Phone = "555-1984",
                    DisplayAs = DisplayOption.LastFirst
                };
                newContact.AddIneraction(new Meeting
                {
                    Date = new DateTime(1984, 9, 10),
                    Location = "Moscow"
                });
                return newContact;
            }
            else if (contactId == 3)
            {
                Contact newContact = new Contact(contactId)
                {
                    First = "Bobby",
                    Last = "Fischer",
                    Email = "fischer@fide.org",
                    Phone = "555-1972",
                    DisplayAs = DisplayOption.LastFirst
                };
                newContact.AddIneraction(new Meeting
                {
                    Date = new DateTime(1972, 7, 11),
                    Location = "Reykjavík, Iceland"
                });
                return newContact;
            }
            else
                return new Contact(contactId);
        }
    }
}
