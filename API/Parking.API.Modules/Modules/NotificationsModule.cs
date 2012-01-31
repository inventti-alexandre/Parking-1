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
    public class NotificationsModule : AbstractBaseModule
    {
        public NotificationsModule()
            : base("Notifications")
        {
        }

        [Api("/GetAll", ApiMethod.GET)]
        public List<Notification> GetAll(int userId, int amount)
        {
            return Notification.GetLastByUserId(userId, amount);
        }
    }
}