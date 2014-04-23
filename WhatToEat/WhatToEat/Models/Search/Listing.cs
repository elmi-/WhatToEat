using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhatToEat.Model;
using WhatToEat.Model.Search;

namespace WhatToEat.Models.Search
{
    public class Listing
    {
        public string id { get; set; }
        public string name { get; set; }
        public Address address { get; set; }
    }
}