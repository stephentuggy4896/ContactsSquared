using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;

namespace ContactsSquared.App_Code
{
    public class Contact
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }
}