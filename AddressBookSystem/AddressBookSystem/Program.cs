// See https://aka.ms/new-console-template for more information
using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook System!");
CreateContact createContact = new CreateContact();
//createContact.personcontacts();
//createContact.Display();
while (true)
{

    Console.WriteLine("********************************************************");
    Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact \n3)Editing Contacts \n4)Delete Contacts \n5)Adding Multiple Contacts \n6)Adding Unique Name \n7)DisplayUniqueName");
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
        default:
            Console.WriteLine("Please Choose From Above Given Options");
            break;
    }

}


