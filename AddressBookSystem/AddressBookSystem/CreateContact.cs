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
        public Dictionary<string, List<PersonContacts>> dict = new Dictionary<string, List<PersonContacts>>();
        
        public void personcontacts()
        {
            PersonContacts person = new();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();
            Addcontacts.Add(person);



        }
        public void Display()
        {
            foreach (var data in Addcontacts)
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

        public void edit()
        {

            Console.WriteLine("Enter the Name to search : ");
            string Name = Console.ReadLine();
            foreach (var data in Addcontacts)
            {
                if (data.FirstName == null)
                {
                    Console.WriteLine("Contact for {0} count not be found.", Name);
                }
                else if (data.FirstName == Name)
                {
                    Console.WriteLine("Choose the Option to Edit the Contact Details : \n1)FirstName\n2)lastName\n3)address\n4)City\n5)State\n6)Zip\n7)Phone Number\n8)Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.WriteLine("Please Enter the First name : ");
                        string abc = Console.ReadLine();
                        data.FirstName = abc;

                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Please Enter the Last name : ");
                        string xyz = Console.ReadLine();
                        data.LastName = xyz;

                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("Please Enter the Address : ");
                        string pqrs = Console.ReadLine();
                        data.Address = pqrs;

                    }
                    else if (option == 4)
                    {
                        Console.WriteLine("Please Enter the City : ");
                        string ijk = Console.ReadLine();
                        data.City = ijk;

                    }
                    else if (option == 5)
                    {
                        Console.WriteLine("Please Enter the State : ");
                        string lmn = Console.ReadLine();
                        data.State = lmn;
                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("Please Enter the Zip : ");
                        string code = Console.ReadLine();
                        data.Zip = code;

                    }
                    else if (option == 7)
                    {
                        Console.WriteLine("Please Enter the Phone Number : ");
                        string number = Console.ReadLine();
                        data.PhoneNumber = number;

                    }
                    else if (option == 8)
                    {
                        Console.WriteLine("Please Enter the Email : ");
                        string abcd1234 = Console.ReadLine();
                        data.Email = abcd1234;

                    }

                    else
                    {
                        Console.WriteLine("Please Choose From Above Given Options :");

                    }
                }
            }

        }
        public void delete()
        {
            Console.WriteLine("Enter the Name to search : ");
            string Name = Console.ReadLine();
            try
            {
                foreach (var data in Addcontacts)
                {
                    if (Addcontacts.Contains(data))
                    {
                        if (data.FirstName == Name)
                        {
                            Console.WriteLine("Given Name Contact Exists");
                            Addcontacts.Remove(data);

                            Console.WriteLine("Contact Details Deleted Successfully");
                            return;
                        }
                    }
                }
                Console.WriteLine("Given Name Contact does not Exists");
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }
        }

        public void AddMultipleContacts(int n)
        {

            while (n > 0)
            {
                personcontacts();
                n--;
            }
        }
        public void AddUniqueName()
        {
            Console.WriteLine("Enter the Firstname to Add Unique Name");
            string name = Console.ReadLine();
            foreach (var data in Addcontacts)
            {
                if (Addcontacts.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("Please Enter an Unique Name");
                        string uniquename = Console.ReadLine();
                        if (dict.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        dict.Add(uniquename, Addcontacts);
                        return;
                    }
                }
            }
            Console.WriteLine("This Contact doesn't Exist");
            return;

        }


        public void DisplayUniqueName()
        {
            Console.WriteLine("Enter the Uniquename of your contacts");
            string name = Console.ReadLine();

            foreach (var PersonContacts in dict)
            {
                if (PersonContacts.Key.Contains(name))
                {
                    foreach (var contact in PersonContacts.Value)
                    {
                        Console.WriteLine("Enter First Name: " + contact.FirstName);
                        Console.WriteLine("Enter Last Name: " + contact.LastName);
                        Console.WriteLine("Enter Address: " + contact.Address);
                        Console.WriteLine("Enter City: " + contact.City);
                        Console.WriteLine("Enter State: " + contact.State);
                        Console.WriteLine("Enter Zip: " + contact.Zip);
                        Console.WriteLine("Enter Phone Number: " + contact.PhoneNumber);
                        Console.WriteLine("Enter Email: " + contact.Email);
                        return;
                    }
                }
                

              

            }
        }

    }

}
   





