using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;

namespace ContactsSquared.App_Code
{
    public enum ContactMethodType1
    {
        Personal,
        Business,
        Nonprofit,
        Other
    }

    public enum ContactMethodType2
    {
        Landline,
        Mobile,
        Fax,
        VoIP,
        Pager,
        Other
    }
    
    public class ContactMethod
    {
        public ObjectId Id { get; set; }

        public ObjectId PrimaryOwnerId { get; set; }

        public ContactMethodType1 ContactMethodType1 { get; set; }

        public ContactMethodType2 ContactMethodType2 { get; set; }
    }
}