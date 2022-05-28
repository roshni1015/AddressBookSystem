// See https://aka.ms/new-console-template for more information
using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook System!");
CreateContact createContact = new CreateContact();
while (true)
{

    Console.WriteLine("********************************************************");
    Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact \n3)Editing Contacts \n4)Delete Contacts \n5)Adding Multiple Contacts \n6)Adding Unique Name \n7)DisplayUniqueName \n8)Searching Person Contacts By a City or State \n9)Count Persons Contacts By City Or State \n10)View Person contacts By City \n11)View Person contacts By State \n12)Sorting alphabetically by Person’s name \n13)Sorting Persons Contacts By City \n14)Sorting Persons Contacts By State \n15)Sorting Persons Contacts By Zip");                                  
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
        default:
            Console.WriteLine("Please Choose From Above Given Options");
            break;
    }

}


