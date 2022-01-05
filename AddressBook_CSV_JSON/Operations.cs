using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_CSV_JSON
{
    public class Operations
    {
        public List<Contacts> add = new List<Contacts>();
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
                Console.WriteLine("****************** Peoples In address book Are ********************");
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
            Console.WriteLine("*************** Searching ***********");
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            var lists = add.FindAll(x => (x.City == city && x.State == state));
            Console.WriteLine($"**************** Peoples In {city} and {state} ********************");
            foreach (Contacts cont in lists)
            {
                Console.WriteLine("First Name:" + cont.Firstname);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
