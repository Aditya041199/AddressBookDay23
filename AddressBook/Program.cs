using AddressBookDay23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            AddressBook ab = new AddressBook("Aditya", "Patil", "New Posari", "Mumbai", "Maharashtra", "patiladi411@gmail.com", 410222, 8308508570);
            ab.DisplayContacts();
        }
    }
}