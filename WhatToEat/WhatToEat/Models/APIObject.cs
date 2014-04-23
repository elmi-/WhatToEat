using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhatToEat.Models
{
    public class APIObject
    {
        public Summary summary { get; set; }
        public List<Listing> listings { get; set; }
    }
}