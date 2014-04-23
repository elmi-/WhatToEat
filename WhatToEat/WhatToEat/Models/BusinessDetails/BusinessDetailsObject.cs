using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhatToEat.Model;
using WhatToEat.Model.Search;

namespace WhatToEat.Models.BusinessDetails
{
    public class BusinessDetailsObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public Address address { get; set; }
        public GeoCode geoCode { get; set; }
        public Logo logos { get; set; }
        public string merchantUrl { get; set; }
    }
}