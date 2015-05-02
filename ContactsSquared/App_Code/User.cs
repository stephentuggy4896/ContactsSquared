using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;

namespace ContactsSquared.App_Code
{
    public class User
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public byte[] HashedPassword { get; set; }
        public string DBName { get; set; }
    }
}