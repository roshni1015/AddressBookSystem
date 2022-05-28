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
        public static Dictionary<string, List<PersonContacts>> dictcity = new Dictionary<string, List<PersonContacts>>();
        public static Dictionary<string, List<PersonContacts>> dictstate = new Dictionary<string, List<PersonContacts>>();


        public void personcontacts()
        {
            PersonContacts person = new();
            int Flag = 0;
            Console.WriteLine("Enter the First name :");
            person.FirstName = Console.ReadLine();
            string FirstNameToBeAdded = person.FirstName;
            foreach (var data in Addcontacts)
            {
                if (Addcontacts.Exists(data => data.FirstName == FirstNameToBeAdded))
                {
                    Flag++;
                    Console.WriteLine("This FirstName already Exist! Can't take the Duplicate Record.");
                    break;
                }
            }
            if (Flag == 0)
            {
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
                Console.WriteLine("***************************************************************************");


            }



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
                if (data.FirstName != Name)
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
        public void SearchByCityState()
        {
            Console.WriteLine("Please Enter the name of City or State:");
            string SearchCityOrState = Console.ReadLine();
            foreach (var data in Addcontacts)
            {

                if (Addcontacts.Exists(data => (data.City == SearchCityOrState) || (data.State == SearchCityOrState)))
                {
                    if ((data.City == SearchCityOrState) || (data.State == SearchCityOrState))
                    {
                        Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                        Console.WriteLine("Address of person is : " + data.Address);
                        Console.WriteLine("City : " + data.City);
                        Console.WriteLine("State :" + data.State);
                        Console.WriteLine("Zip :" + data.Zip);
                        Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                        Console.WriteLine("Email of person : " + data.Email);
                        Console.WriteLine();


                    }
                }
            }


        }
        public void CountContactsbyCityState()
        {
            Console.WriteLine("Please Enter the Name of City or State:");
            string SearchCityOrState = Console.ReadLine();

            int count = 0;
            foreach (var data in Addcontacts)
            {
                string actualcity = data.City;
                string actualState = data.State;
                if (Addcontacts.Exists(data => (data.City == SearchCityOrState) || (data.State == SearchCityOrState)))
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} Persons Contacts in {1}:", count, SearchCityOrState);
        }
        public void ContactByCityInDictionary()
        {

            try
            {
                var data = Addcontacts.GroupBy(x => x.City);
                foreach (var cities in data)
                {
                    List<PersonContacts> cityList = new List<PersonContacts>();
                    foreach (var city in cities)
                    {
                        cityList.Add(city);
                    }
                    dictcity.Add(cities.Key, cityList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DictionayCity_Display()
        {
            if (dictcity.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dictcity.Count >= 1)
            {
                foreach (KeyValuePair<string, List<PersonContacts>> addressBooks in dictcity)
                {
                    Console.WriteLine("Contacts From City: " + addressBooks.Key);
                    foreach (PersonContacts contact in addressBooks.Value)
                    {
                        Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                        Console.WriteLine("Address of person is : " + contact.Address);
                        Console.WriteLine("City : " + contact.City);
                        Console.WriteLine("State :" + contact.State);
                        Console.WriteLine("Zip :" + contact.Zip);
                        Console.WriteLine("Phone Number of person: " + contact.PhoneNumber);
                        Console.WriteLine("Email of person : " + contact.Email);
                        Console.WriteLine();

                    }
                }
            }
        }
        public void ContactByStateInDictionary()
        {

            try
            {
                var data = Addcontacts.GroupBy(x => x.State);
                foreach (var states in data)
                {
                    List<PersonContacts> stateList = new List<PersonContacts>();
                    foreach (var state in states)
                    {
                        stateList.Add(state);
                    }
                    dictstate.Add(states.Key, stateList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DictionayState_Display()
        {
            if (dictstate.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dictstate.Count >= 1)
            {
                foreach (KeyValuePair<string, List<PersonContacts>> addressBooks in dictstate)
                {
                    Console.WriteLine("Contacts From State: " + addressBooks.Key);
                    foreach (PersonContacts contact in addressBooks.Value)
                    {
                        Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
                        Console.WriteLine("Address of person is : " + contact.Address);
                        Console.WriteLine("City : " + contact.City);
                        Console.WriteLine("State :" + contact.State);
                        Console.WriteLine("Zip :" + contact.Zip);
                        Console.WriteLine("Phone Number of person: " + contact.PhoneNumber);
                        Console.WriteLine("Email of person : " + contact.Email);
                        Console.WriteLine();
                    }
                }
            }
        }
        public void SortingContactsByName()
        {
            foreach (var data in Addcontacts.OrderBy(s => s.FirstName).ToList())
            {
                if (Addcontacts.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.Zip);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }
        public void SortingContactsByCity()
        {

            foreach (var data in Addcontacts.OrderBy(s => s.City).ToList())
            {
                if (Addcontacts.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.Zip);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        public void SortingContactsByState()
        {

            foreach (var data in Addcontacts.OrderBy(s => s.State).ToList())
            {
                if (Addcontacts.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.Zip);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        public void SortingContactsByZip()
        {

            foreach (var data in Addcontacts.OrderBy(s => s.Zip).ToList())
            {
                if (Addcontacts.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("Zip :" + data.Zip);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }
        string path = @"C:\Users\Admin\source\c#\AddressBookSystem\AddressBookSystem\AddressBookSystem\usingFileIO.txt";
        public void WriteToTextFile()
        {
            //string ABC = @"C:\Users\santo\OneDrive\Desktop\CSharpCodes\AddressBook\AddressBook\TextFile1.txt";
            using (TextWriter Tw = File.AppendText(path))
            {
                foreach (PersonContacts item in Addcontacts)
                {
                    Tw.WriteLine("First Name:" + item.FirstName.ToString());
                    Tw.WriteLine("Last Name:" + item.LastName.ToString());
                    Tw.WriteLine("Address:" + item.Address.ToString());
                    Tw.WriteLine("City:" + item.City.ToString());
                    Tw.WriteLine("State:" + item.State.ToString());
                    Tw.WriteLine("Zip:" + item.Zip.ToString());
                    Tw.WriteLine("PhoneNumber:" + item.PhoneNumber.ToString());
                    Tw.WriteLine("EmailId:" + item.Email.ToString());

                }
            }
        }
        public void ReadFileIO()
        {
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Reading All the Text\n" + lines);
        }
    }
}



      
        

   





