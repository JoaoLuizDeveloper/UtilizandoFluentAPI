using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveEFCore.Entities
{
    public class ContactInformation
    {
        public ContactInformation()
        {

        }

        public ContactInformation(string fullAddress, string phoneNumber)
        {
            FullAddress = fullAddress;
            PhoneNumber = phoneNumber;
        }

        public int Id { get; private set; }
        public string FullAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public int SchoolId { get; private set; }
    }
}
