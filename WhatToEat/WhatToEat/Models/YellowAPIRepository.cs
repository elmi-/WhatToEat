using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using WhatToEat.Models.BusinessDetails;
using WhatToEat.Models.Search;

namespace WhatToEat.Models
{
    public class YellowAPIRepository
    {
        //YellowAPI base URI (required)
        //learn more at http://www.yellowapi.com/docs/places/#findbusiness
        private string SearchURIbase = "http://api.sandbox.yellowapi.com/FindBusiness/?what=bar&apikey=";

        private string DetailsURIbase = "http://api.sandbox.yellowapi.com/GetBusinessDetails/?apikey=";

        //Unique APIKey, register at http://developer.yellowapi.com/apps/register (required)
        private string APIkey = "cyfhpy4udwxjkumrycnmbt87";

        //Unique identifer for user (ie. IP Address, session ID, etc.) (required)
        private string UID = "&UID=127.0.0.1&";

        //Format of output, default XML (optional)
        private string fmt = "fmt=JSON&";

        private WebClient client = new WebClient();

        public APIObject GetAPIObject(string where, int? pg)
        {
            //Number of listings returned, default 40 (optional)
             string pgLen = "pgLen=100&";

            var response = client.DownloadString(new Uri(SearchURIbase + APIkey + UID + pgLen + fmt + "where=" + where + "&pg=" + pg));
            
            var apiObject = new JavaScriptSerializer().Deserialize<APIObject>(response);

            return apiObject;
        }

        public BusinessDetailsObject GetBusinessDetails(string listingId, string businessName, string city, string prov)
        {
            //var response = client.DownloadString(new Uri(DetailsURIbase + APIkey + UID + fmt + "listingId=" + listingId + "&bus-name=" + businessName + "&city=" + city + "&prov" + prov));
            var response = client.DownloadString(new Uri("http://api.sandbox.yellowapi.com/GetBusinessDetails/?apikey=cyfhpy4udwxjkumrycnmbt87&UID=127.0.0.1&fmt=JSON&listingId=" +  listingId + "&bus-name=" + businessName + "&city=" + city + "&prov=" +prov));

            var businessDetailsObject = new JavaScriptSerializer().Deserialize<BusinessDetailsObject>(response);

            return businessDetailsObject;
        }
    }
}