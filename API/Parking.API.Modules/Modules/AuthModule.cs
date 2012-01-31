﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.ViewEngines.Razor;
using Nancy.Serializers.Json;
using Sieena.Parking.API.Models;

namespace Sieena.Parking.API.Modules
{
    public class AuthModule : AbstractBaseModule
    {
        public AuthModule()
            : base("Auth")
        {
          
        }

        [Api("/ValidateUser", ApiMethod.GET)]
        public bool ValidateUser(dynamic parameters)
        {
            return User.Validate(parameters["user"], parameters["password"]);
        }
    }
}