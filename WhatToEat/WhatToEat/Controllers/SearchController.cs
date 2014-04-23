using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WhatToEat.Models;
using PagedList;

namespace WhatToEat.Controllers
{
    public class SearchController : Controller
    {

        private YellowAPIRepository yellowRepository;

        public SearchController()
        {
            this.yellowRepository = new YellowAPIRepository();
        }

        // GET: /Search/Find?=where="string"
        public ActionResult Find(string where, int? pg)
        {
            int pageNumber = (pg ?? 1);

            var apiObject = yellowRepository.GetAPIObject(where, pageNumber);

            return View(apiObject);
        }

        public ActionResult Details(string listingId, string businessName, string city, string prov)
        {
            //listingId = "8225706";

            //businessName = "Yellow-Pages-Group";

            //city = "Toronto";

            //prov = "ON";

            var businessDetailsObject = yellowRepository.GetBusinessDetails(listingId, businessName, city, prov);

            return View(businessDetailsObject);
        }

    }
}
