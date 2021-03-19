using System;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_practice1
{
    [Serializable]
    public class Contact : IComparable<Contact>
    {
        public Contact()
        {
        }

        public Contact(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            FullName = string.Concat(firstName + " " + lastName);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public int CompareTo(Contact c)
        {
            return FirstName.CompareTo(c.FirstName);
        }

        public string Display()
        {
            string data = string.Concat(FullName + " " + PhoneNumber);
            return data;
        }
    }
}
