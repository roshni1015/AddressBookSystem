// See https://aka.ms/new-console-template for more information
using AddressBookSystem;
using System.Text;

Console.WriteLine("Welcome to AddressBook System!");
CreateContact createContact = new CreateContact();
AddressBookRepo repo = new AddressBookRepo();
while (true)
{

    Console.WriteLine("********************************************************");
    Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact \n3)Editing Contacts \n4)Delete Contacts \n5)Adding Multiple Contacts \n6)Adding Unique Name \n7)DisplayUniqueName \n8)Searching Person Contacts By a City or State \n9)Count Persons Contacts By City Or State \n10)View Person contacts By City \n11)View Person contacts By State \n12)Sorting alphabetically by Person’s name \n13)Sorting Persons Contacts By City \n14)Sorting Persons Contacts By State \n15)Sorting Persons Contacts By Zip \n16)Writing AddressBook using File IO \n17)Reading AddressBook Using File IO \n18)Writing AddressBook Using File CSV \n19)Reading AddressBook Using File CSV \n20)Writing AddressBook Using File JSON \n21)Reading AddressBook Using File JSON" +
        "\n22)Display of AddressBook\n23)Display of PersonDetail1\n24)Display of Address_Book1\n25)Display of PersonTypes1" +
        "\n26)Display of PersonsDetail_Type1\n27)Display of Employee_Department1\n28)Update Employee Details\n29)Add Column DateAdded\n30)Contacts in date range\n31)count by city / State");                                  
    int option = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("********************************************************");

    switch (option)
    {
        case 1:
            createContact.personcontacts();
            break;
        case 2:
            createContact.Display();
            break;
        case 3:
            createContact.edit();
            break;
        case 4:
            createContact.delete();
            break;
        case 5:
            Console.WriteLine("How many no. of contacts");
            int n = Convert.ToInt32(Console.ReadLine());
            createContact.AddMultipleContacts(n);
            break;
        case 6:
            createContact.AddUniqueName();
            break;
        case 7:
            createContact.DisplayUniqueName();
            break;
        case 8:
            createContact.SearchByCityState();
            break;
        case 9:
            createContact.CountContactsbyCityState();
            break;
        case 10:
            createContact.ContactByCityInDictionary();
            createContact.DictionayCity_Display();
            break;
        case 11:
            createContact.ContactByStateInDictionary();
            createContact.DictionayState_Display();
            break;
        case 12:
            createContact.SortingContactsByName();
            break;
        case 13:
            Console.WriteLine("Sorting Persons Contacts by City");
            createContact.SortingContactsByCity();
            break;
        case 14:
            Console.WriteLine("Sorting Persons Contacts by State");
            createContact.SortingContactsByState();
            break;
        case 15:
            Console.WriteLine("Sorting Persons Contacts by Zip");
            createContact.SortingContactsByZip();
            break;
        case 16:
            createContact.WriteToTextFile();
            break;
        case 17:
            createContact.ReadFileIO();
            break;
        case 18:
            createContact.WriteFileCSV();
            break;
        case 19:
            createContact.ReadFileCSV();
            break;
        case 20:
            createContact.WriteJson();
            break;
        case 21:
            createContact.ReadJsonFile();
            break;
        case 22:
            Console.WriteLine("Display of AddressBook");
            repo.DisplayAddressBook();
            break;
        case 23:
            Console.WriteLine("Display of PersonDetail1");
            repo.DisplayPersonDetail1();
            break;
        case 24:
            Console.WriteLine("Display of Address_Book1");
            repo.DisplayAddress_Book1();
            break;
        case 25:
            Console.WriteLine("Display of PersonTypes1");
            repo.DisplayPersonTypes1();
            break;
        case 26:
            Console.WriteLine("Display of PersonsDetail_Type1");
            repo.DisplayPersonsDetail_Type1();
            break;
        case 27:
            Console.WriteLine("Display of Employee_Department1");
            repo.DisplayEmployee_Department1();
            break;
        case 28:
            Console.WriteLine("Display of PersonDetail1");
            string address = repo.UpdateDetails();
            Console.WriteLine(address);
            break;
        case 29:
            repo.AddEmployeeDetails();
            break;
        case 30:
            repo.GetDetailsInPeroid();
            break;
        case 31:
            int countCity = repo.CountOfEmployeeDetailsByCity();
            Console.WriteLine("Count of Records by City :" + countCity);
            int countstate = repo.CountOfEmployeeDetailsByState();
            Console.WriteLine("Count of Records by state :" + countstate);
            break;
        default:
            Console.WriteLine("Please Choose From Above Given Options");
            break;
    }

}


