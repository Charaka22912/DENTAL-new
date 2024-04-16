using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DENTAL
{
    public class Doctor:Person
    {
        public int DocID;


       public  Doctor(string firstName, string lastName, string address, string contactNo, DateTime dob, int nic ,int DocID)
             : base(firstName, lastName, address, contactNo, dob, nic)
        {
            this.DocID = DocID;
        }
    }
}
