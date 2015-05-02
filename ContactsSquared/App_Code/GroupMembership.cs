using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsSquared.App_Code
{
    public class GroupMembership
    {
        public Group Group { get; set; }
        public Person Person { get; set; }
    }
}