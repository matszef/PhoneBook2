using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        // 1
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        
        // 2
        public void DisplayContactByNumber(string number)
        {
            var searchNumber = Contacts.FirstOrDefault(n => n.Number == number);
            
            if (searchNumber != null)
                DisplayContact(searchNumber);
            else
                Console.WriteLine("contact not found!");
        }

        // 3
        public void DisplayAllContacts()
        {
            DisplayContacts(Contacts);
        }

        // 4
        public void DisplayContactByPhrase(string searchPhrase)
        {
            var matchingPhrase = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContacts(matchingPhrase);
        }

        // 5
        public void DeleteContact(string number)
        {
            var deletedContact = Contacts.FirstOrDefault(c => c.Number == number);
            Contacts.Remove(deletedContact);
        }

        // auxiliary methods
        private void DisplayContacts(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
                DisplayContact(contact);
        }

        private void DisplayContact(Contact contact)
        {
            Console.WriteLine($"{contact.Name}, {contact.Number}");
        }

        
    }
}
