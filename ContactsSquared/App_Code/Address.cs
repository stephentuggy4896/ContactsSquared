using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsSquared.App_Code
{
    public class Address : ContactMethod
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string City { get; set; }

        public string StateOrProvince { get; set; }

        public string ZipOrPostalCode { get; set; }

        public string Country { get; set; }
    }
}