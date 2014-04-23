using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhatToEat.Models.Search;

namespace WhatToEat.Models.Search
{
    public class APIObject
    {
        public Summary summary { get; set; }
        public List<Listing> listings { get; set; }
    }
}