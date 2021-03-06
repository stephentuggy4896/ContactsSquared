﻿/**
 * Copyright 2015-2016 Stephen G. Tuggy, Jose Cabrera Jr., and Joshua Weston.
 * 
 * This file is part of ContactsSquared.
 *
 * ContactsSquared is free software: you can redistribute it and/or modify it 
 * under the terms of the GNU General Public License as published by the Free 
 * Software Foundation, either version 3 of the License, or (at your option) 
 * any later version.
 *
 * ContactsSquared is distributed in the hope that it will be useful, but 
 * WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for 
 * more details.
 *
 * You should have received a copy of the GNU General Public License along with 
 * ContactsSquared.  If not, see <http://www.gnu.org/licenses/>.
 */

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
