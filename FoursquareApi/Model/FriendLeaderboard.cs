﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Foursquare.Model;

namespace Foursquare.Model
{
    public class FriendLeaderboard : IFoursquareBase
    {
        public List<UserVisits> crownSummary { get; set; }
    }
}
