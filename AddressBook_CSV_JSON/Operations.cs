using AddressBook_CSV_JSON;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_CSV_JSON
{
    public class Operations
    {
        public static List<Contacts> add = new List<Contacts>();
        public void AddContact(Contacts con)
        {
            add.Add(con);
        }
        public void DisplayContacts()
        {
            Console.WriteLine("Enter Firstname");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Enter Pincode");
            string pincode = Console.ReadLine();
            add.Add(new Contacts()
            {
                Firstname = fname,
                Lastname = lname,
                Address = address,
                City = city,
                State = state,
                Zipcode = zipcode,
                Pincode = pincode
            });

            foreach (var con in add)
            {
                Console.WriteLine("****************Peoples In address book********************");
                Console.WriteLine("First Name:" + con.Firstname);
                Console.WriteLine("Last Name:" + con.Lastname);
                Console.WriteLine("Address:" + con.Address);
                Console.WriteLine("City:" + con.City);
                Console.WriteLine("State:" + con.State);
                Console.WriteLine("Zipcode:" + con.Zipcode);
                Console.WriteLine("Pincode:" + con.Pincode);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
        public void SearchByCityState()
        {
            Console.WriteLine("********Search*******");
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            var lists = add.FindAll(x => (x.City == city && x.State == state));
            Console.WriteLine($"***************** Peoples In {city} and {state} **********************");
            foreach (Contacts cont in lists)
            {
                Console.WriteLine("First Name:" + cont.Firstname);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    
        public static void WriteData()
        {
            const string FilePath = @"D:\bridzlabz\AddressBook_CSV&JSON\AddressBook_CSV_JSON\new.txt";

            // Creating a file for writing a data
            using (StreamWriter sw = File.CreateText(FilePath))
            {
                foreach (var con in add)
                {
                    Console.WriteLine("Added record in file");
                    sw.WriteLine("****************** Peoples In address books are *********************");
                    sw.WriteLine("First Name:" + con.Firstname);
                    sw.WriteLine("Last Name:" + con.Lastname);
                    sw.WriteLine("Address:" + con.Address);
                    sw.WriteLine("City:" + con.City);
                    sw.WriteLine("State:" + con.State);
                    sw.WriteLine("Zipcode:" + con.Zipcode);
                    sw.WriteLine("Pincode:" + con.Pincode);
                    sw.WriteLine("--------------------------------------------------------------");
                }
            }
        }
        //writing contacts in CSV file
        public static void WriteDataUsingCSV()
        {
            try
            {
                string Filepath = @"D:\bridzlabz\AddressBook_CSV&JSON\AddressBook_CSV_JSON\CSVFile.csv";

                using (CsvWriter sw = new CsvWriter(new StreamWriter(Filepath), CultureInfo.InvariantCulture))
                {
                    sw.WriteHeader<Contacts>();
                    sw.WriteRecords("\n");
                    sw.WriteRecords(add);
                }
            }
            catch (FileNotFoundException f)
            {
                new Exception(f.FileName);
            }
        }
        //reading contacts using CSVReader
        public static void ReadDataUsingCSV()
        {
            try
            {
                string Filepath = @"D:\bridzlabz\AddressBook_CSV&JSON\AddressBook_CSV_JSON\CSVFile.csv";

                using (CsvReader sw = new CsvReader(new StreamReader(Filepath), CultureInfo.InvariantCulture))
                {
                    var Record = sw.GetRecords<Contacts>();
                    foreach (var data in Record)
                    {
                        Console.WriteLine("*********** Addressboo System ************");
                        Console.WriteLine(data.Firstname);
                        Console.WriteLine(data.Lastname);
                        Console.WriteLine(data.Address);
                        Console.WriteLine(data.City);
                        Console.WriteLine(data.State);
                        Console.WriteLine(data.Zipcode);
                        Console.WriteLine(data.Pincode);
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (FileNotFoundException f)
            {
                new Exception(f.FileName);
            }
        }
    }
}
