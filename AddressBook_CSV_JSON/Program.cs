////// See https://aka.ms/new-console-template for more information

using AddressBook_CSV_JSON;
Operations op = new Operations();

int count = 0;//counter to break the while loop

while (count == 0)
{
    Console.Write("Select Number:\n1)AddContacts\n2)SearchCityState\n3)WriteData\n4)WriteDataUsingCSV\n5)ReadDataUsingCSV");
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
        case 3:
            Operations.WriteData();
            break;
        case 4:
            Operations.WriteDataUsingCSV();
            break;
        case 5:
            Operations.ReadDataUsingCSV();
            break;

        default:
            Console.WriteLine("\nInvalid Option");
            break;
    }
}




















////Console.WriteLine("Hello, World!");
//using AddressBook_CSV_JSON;
//bool status = true;
//Operations add = new Operations();
//while (status)
//{
//    Console.WriteLine("Select:\n1)Add New Entry\n2)Search\n3)Count\n4)Read and Write file\n5)Write using csv");
//    int op = Convert.ToInt16(Console.ReadLine());
//    switch (op)
//    {
//        case 1:
//            add.Show();


//            break;
//        case 2:
//            add.Show();

//            add.SearchByCityState();
//            break;
//        case 3:
//            add.Show();
//            add.UniqueContact();
//            add.Countperson();
//            break;
//        case 4:
//            Operations.WriteData();
//            break;
//        case 5:
//            Operations.WriteDataUsingCSV();
//            Operations.ReadDataUsingCSV();
//            break;
//    }
//}