using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatToEat.Models
{
    public class Listing
    {
        public string id { get; set; }
        public string name { get; set; }
        public Address address { get; set; }
    }
}