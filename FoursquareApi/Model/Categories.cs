﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Foursquare.Model;

namespace Foursquare.Model
{
    public sealed class Categories : IFoursquareBase
    {
        public List<Category> categories { get; set; }
    }
}