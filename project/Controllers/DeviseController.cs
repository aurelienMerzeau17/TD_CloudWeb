using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using project.Models; 
namespace project.Controllers
{
    public class DeviseController : ApiController
    {
        public string Get(string ValueOrig, string deviseOrig, string devisefinale)
        {
            var client = new WebClient();
            string html = client.DownloadString("http://rate-exchange.appspot.com/currency?from=" + deviseOrig + "&to=" + devisefinale);
            JObject o = JObject.Parse(html);
            double rate = Convert.ToDouble(o["rate"].ToString());
            double value = double.Parse(ValueOrig);
            double res = rate * value;
            return res.ToString();
        }
    }
}
