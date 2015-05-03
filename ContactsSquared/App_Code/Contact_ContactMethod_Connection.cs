using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;

namespace ContactsSquared.App_Code
{
    public class Contact_ContactMethod_Connection
    {
        public ObjectId Id { get; set; }

        public ObjectId ContactId { get; set; }

        public ObjectId ContactMethodId { get; set; }
    }
}