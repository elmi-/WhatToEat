using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatToEat.Models
{
    public class Summary
    {
        public string what { get; set; }
        public string where { get; set; }
        public int firstListing { get; set; }
        public int lastListing { get; set; }
        public int totalListings { get; set; }
        public int pageCount { get; set; }
        public int currentPage { get; set; }
        public int listingsPerPage { get; set; }
        public string Prov { get; set; }
    }
}