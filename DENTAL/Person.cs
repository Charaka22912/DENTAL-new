using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DENTAL
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string contact_No;
        public DateTime DOB;
        public int NIC;


        public Person(string firstName, string lastName, string address, string contactNo, DateTime dob, int nic)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            contact_No = contactNo;
            DOB = dob;
            NIC = nic;
        }
    }
}
