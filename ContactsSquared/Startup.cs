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

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsSquared.Startup))]
namespace ContactsSquared
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
