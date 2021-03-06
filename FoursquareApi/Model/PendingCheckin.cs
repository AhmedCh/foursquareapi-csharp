﻿using System;
using System.Collections.Generic;

namespace Foursquare.Model
{
    public class PendingCheckin : IFoursquareType
    {
        public string id { get; set; }
        public long createdAt { get; set; }
        public String type { get; set; }
        public String shout { get; set; }
        public List<Entity> entities { get; set; }
        public Venue venue { get; set; }
        public User user { get; set; }
        public List<User> with { get; set; }
    }
}
