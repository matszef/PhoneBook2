using System;

namespace PhoneBook2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Mobile phone book app ***");

            Console.WriteLine("Options:");
            Console.WriteLine("1 - add new contact");
            Console.WriteLine("2 - display contact by number");
            Console.WriteLine("3 - display all contacts");
            Console.WriteLine("4 - search contacts");
            Console.WriteLine("5 - delete contact");
            Console.WriteLine("x - exit from app...");

            string userInput = Console.ReadLine();

            PhoneBook phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":

                        Console.Write("Name of the contact: ");
                        string name = Console.ReadLine();
                        Console.Write("Number of the contact: ");
                        string number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        Console.WriteLine($"{newContact.Name} added.");

                        break;
                    case "2":

                        Console.Write("Enter a number to display: ");
                        string numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContactByNumber(numberToSearch);

                        break;
                    case "3":

                        Console.WriteLine();
                        Console.WriteLine("You phone book:");
                        phoneBook.DisplayAllContacts();

                        break;
                    case "4":

                        Console.Write("Enter phrase to search for contact: ");
                        string phraseToSearch = Console.ReadLine();
                        phoneBook.DisplayContactByPhrase(phraseToSearch);

                        break;
                    case "5":

                        Console.Write("Enter a contact to delete:");
                        string deleteContact = Console.ReadLine();
                        phoneBook.DeleteContact(deleteContact);
                        Console.WriteLine($"{deleteContact} deleted...");

                        break;
                    case "x":

                        Console.WriteLine("Closing the app...");
                        return;

                        break;
                    default:
                        Console.WriteLine("choose one of above options");
                        break;
                }

                userInput = Console.ReadLine();
            }
        }
    }
}
