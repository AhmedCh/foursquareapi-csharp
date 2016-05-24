﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Foursquare.Model;

namespace Foursquare.Model
{
    public sealed class BrowseExploreItem : IFoursquareBase
    {
        public Venue venue { get; set; }
        public Photo photo { get; set; }
        public FoursquareList<SnippetDetailWrapper> snippets { get; set; }
        public Promoted promoted { get; set; }

        public sealed class SnippetDetailWrapper : IFoursquareBase
        {
            public SnippetDetail detail { get; set; }
        }
    }
}
