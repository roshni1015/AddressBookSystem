// See https://aka.ms/new-console-template for more information
using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook System!");
CreateContact createContact = new CreateContact();
//createContact.personcontacts();
//createContact.Display();
while (true)
{
    Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            createContact.personcontacts();
            break;
        case 2:
            createContact.Display();
            break;
        default:
            Console.WriteLine("Please Choose From Above Given Options");
            break;
    }

}

