// See https://aka.ms/new-console-template for more information
using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook System!");
CreateContact createContact = new CreateContact();
//createContact.personcontacts();
//createContact.Display();
while (true)
{
    Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact \n3)Editing Contacts");
    int option = Convert.ToInt32(Console.ReadLine());
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
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }

}


