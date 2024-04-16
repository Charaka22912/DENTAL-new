using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DENTAL
{
    public class Patient : Person
    {
        public string PatientID;
        public string Medical_History;

        
        public Patient(string firstName, string lastName, string address, string contactNo, DateTime dob, int nic ,
                       string PatientID, string Medical_History)
            : base(firstName, lastName, address, contactNo, dob, nic)
        {

            this.PatientID = PatientID;
            this.Medical_History = Medical_History;
        }

        public void RegPatient()
        {

        }

    }
}
