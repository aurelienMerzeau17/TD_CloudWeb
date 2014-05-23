using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace project.Models
{
    public class Currencies
    {
        public Dictionary<string, string> listCurrencies = new Dictionary<string, string>();
        public Currencies()
        {
            var client = new WebClient();
            string html = client.DownloadString("http://openexchangerates.org/currencies.json");

            var o = JObject.Parse(html);

            foreach (var t in o)
            {
                listCurrencies.Add(t.Key.ToString(), t.Value.ToString());
            }
        }
    }
}