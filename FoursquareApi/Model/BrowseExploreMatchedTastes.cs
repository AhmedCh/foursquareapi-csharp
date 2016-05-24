﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Foursquare.Model;

namespace Foursquare.Model
{
    public sealed class BrowseExploreMatchedTastes : IFoursquareBase
    {
        public string header { get; set; }
        public List<Taste> tastes { get; set; }
    }
}