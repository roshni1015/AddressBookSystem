using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class CreateContact
    {
        List<PersonContacts> Addcontacts = new List<PersonContacts>();
        public void personcontacts()
        {
            PersonContacts person = new PersonContacts();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter City: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter State: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Zip: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.LastName = Console.ReadLine();
            Addcontacts.Add(person);
            Display();


        }
        public void Display()
        {
            foreach(var data in Addcontacts)
            {
              Console.WriteLine("Enter First Name: " + data.FirstName);
              Console.WriteLine("Enter Last Name: " + data.LastName);
              Console.WriteLine("Enter Address: " + data.Address);
              Console.WriteLine("Enter City: " + data.City);
              Console.WriteLine("Enter State: " + data.State);
              Console.WriteLine("Enter Zip: " + data.Zip);
              Console.WriteLine("Enter Phone Number: " + data.PhoneNumber);
              Console.WriteLine("Enter Email: " + data.Email);
            }
        }
    }
}
