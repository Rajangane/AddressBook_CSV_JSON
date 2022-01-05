// See https://aka.ms/new-console-template for more information
using AddressBook_CSV_JSON;
Operations op = new Operations();
int count = 0;//counter to break the while loop

while (count == 0)
{
    Console.Write("Select Number:\n1)AddContacts\n2)SearchCityState");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {

        case 1:
            op.DisplayContacts();
            break;
        case 2:
            op.SearchByCityState();
            op.DisplayContacts();
            break;
        default:
            Console.WriteLine("\nInvalid Option");
            break;
    }
}