using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WhatToEat.Models
{
    public class YellowAPIRepository
    {
        public static APIObject GetAPIObject(string where, int? pg)
        {
            //YellowAPI base URI (required)
            //learn more at http://www.yellowapi.com/docs/places/#findbusiness
             string URIbase = "http://api.sandbox.yellowapi.com/FindBusiness/?what=bar&apikey=";

            //Unique APIKey, register at http://developer.yellowapi.com/apps/register (required)
             string APIkey = "cyfhpy4udwxjkumrycnmbt87";

            //Unique identifer for user (ie. IP Address, session ID, etc.) (required)
             string UID = "&UID=127.0.0.1&";

            //Number of listings returned, default 40 (optional)
             string pgLen = "pgLen=100&";

            //Format of output, default XML (optional)
             string fmt = "fmt=JSON&";
            var client = new WebClient();


            var response = client.DownloadString(new Uri(URIbase + APIkey + UID + pgLen + fmt + "where=" + where + "&pg=" + pg));
            
            var apiObject = new JavaScriptSerializer().Deserialize<APIObject>(response);

            return apiObject;
        }
    }
}