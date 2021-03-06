﻿namespace Foursquare.Model
{
    public class Taste : IFoursquareType
    {
        public string id { get; set; }
        public string text { get; set; }
        public int venueFrequency { get; set; }
        public int tipFrequency { get; set; }
        public bool onUser { get; set; }
        public bool topical { get; set; }
        public bool upsell { get; set; }
    }
}
