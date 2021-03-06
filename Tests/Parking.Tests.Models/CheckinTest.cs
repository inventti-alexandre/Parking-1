﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sieena.Parking.Tests.Models
{
    using Parking.API.Models;

    [TestClass]
    public class CheckinTest
    {
        //[TestMethod]
        public void CheckInTest()
        {
            //Checkin.ClearSpace(28);
            Checkin.ClearSpace(29);
            Checkin.ClearUser(92);
            //Checkin.ClearUser(39);
            //Checkin added2 = Checkin.CheckIn(new Checkin() { StartTime = DateTime.Now, SpaceId = 28, UserId = 36, RegisteredBy = 39, RegisteredFrom = 1 });
            Checkin added = Checkin.CheckIn(new Checkin() { StartTime = DateTime.Now, SpaceId = 29, UserId = 92, RegisteredBy = 39, RegisteredFrom = 1 });
            Assert.IsNotNull(added);
            Assert.IsNotNull(added.CheckInId);
        }

        //[TestMethod]
        public void CheckOutTest()
        {
            Checkin added = Checkin.GetLastForUser(92);
            if (added == null || added.EndTime.HasValue)
            {
                added = Checkin.CheckIn(new Checkin() { StartTime = DateTime.Now, SpaceId = 1, UserId = 92, RegisteredBy = 39, RegisteredFrom = 1 });
            }

            Checkin removed = Checkin.CheckOut(added.CheckInId);
            Assert.AreEqual(added.CheckInId, removed.CheckInId);
            Assert.IsNotNull(removed.EndTime);
            Assert.IsNotNull(removed.CheckInId);
        }
    }
}
