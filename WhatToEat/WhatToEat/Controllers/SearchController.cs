using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WhatToEat.Models;

namespace WhatToEat.Controllers
{
    public class SearchController : Controller
    {
        //YellowAPI base URI (required)
        //learn more at http://www.yellowapi.com/docs/places/#findbusiness
        private string URIbase = "http://api.sandbox.yellowapi.com/FindBusiness/?what=bar&apikey=";

        //Unique APIKey, register at http://developer.yellowapi.com/apps/register (required)
        private string APIkey = "cyfhpy4udwxjkumrycnmbt87";

        //Unique identifer for user (ie. IP Address, session ID, etc.) (required)
        private string UID = "&UID=127.0.0.1&";

        //Number of listings returned, default 40 (optional)
        private string pgLen = "pgLen=100&";

        //Format of output, default XML (optional)
        private string fmt = "fmt=JSON&";

        // GET: /Search/Find?=where="string"
        public ActionResult Find(string where)
        {
            var client = new WebClient();
            var response = client.DownloadString(new Uri(URIbase + APIkey + UID + pgLen + fmt + "where=" + where));
            APIObject apiObject = new JavaScriptSerializer().Deserialize<APIObject>(response);

            return View("Find", apiObject);
        }

    }
}
