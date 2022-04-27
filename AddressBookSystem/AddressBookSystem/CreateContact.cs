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
            Display();


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
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please Enter the First name : ");
                            string abc = Console.ReadLine();
                            data.FirstName = abc;
                            break;
                        case 2:
                            Console.WriteLine("Please Enter the Last name : ");
                            string xyz = Console.ReadLine();
                            data.LastName = xyz;
                            break;
                        case 3:
                            Console.WriteLine("Please Enter the Address : ");
                            string pqrs = Console.ReadLine();
                            data.Address = pqrs;
                            break;
                        case 4:
                            Console.WriteLine("Please Enter the City : ");
                            string ijk = Console.ReadLine();
                            data.City = ijk;
                            break;
                        case 5:
                            Console.WriteLine("Please Enter the State : ");
                            string lmn = Console.ReadLine();
                            data.State = lmn;
                            break;
                        case 6:
                            Console.WriteLine("Please Enter the Zip : ");
                            string code = Console.ReadLine();
                            data.Zip = code;
                            break;
                        case 7:
                            Console.WriteLine("Please Enter the Phone Number : ");
                            string number = Console.ReadLine();
                            data.PhoneNumber = number;
                            break;
                        case 8:
                            Console.WriteLine("Please Enter the Email : ");
                            string abcd1234 = Console.ReadLine();
                            data.Email = abcd1234;
                            break;
                        default:
                            Console.WriteLine("Please Choose From Above Given Options :");
                            break;
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
    }
}
