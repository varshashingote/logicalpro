using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Collection
{
    public class AddressBook
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static Dictionary<int, List<Contacts>> dictionarybook = new Dictionary<int, List<Contacts>>();


        public static void Add()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter the id");
            contacts.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            contacts.name = Console.ReadLine();
            Console.WriteLine("Enter the address");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter the ContactsNumber");
            contacts.contactNumber = Convert.ToInt32(Console.ReadLine());
            Person.Add(contacts);

        }
        public static void display()
        {
            Console.WriteLine("DisplayAddressBook");
            foreach (var item in Person)
            {
                Console.WriteLine("Name: " + item.name);
                Console.WriteLine("id: " + item.id);
                Console.WriteLine("Address: " + item.Address);
                Console.WriteLine("ContactsNumber : " + item.contactNumber);

            }
        }
    }
    
}

            