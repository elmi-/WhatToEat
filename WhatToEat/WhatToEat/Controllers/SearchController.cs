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
        // GET: /Search/Find?=where="string"
        public ActionResult Find(string where, int? pg)
        {

            int pageNumber = (pg ?? 1);

            var apiObject = YellowAPIRepository.GetAPIObject(where, pageNumber);

            return View(apiObject);
        }
    }
}
