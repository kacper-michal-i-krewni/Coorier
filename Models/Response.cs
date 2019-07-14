using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Coorier.Models
{
    public class Response
    {
        public string getResponse()
        {
            string url = String.Format("https://community-open-weather-map.p.rapidapi.com/weather?callback=test&id=2172797&units=%22metric%22+or+%22imperial%22&mode=xml%2C+html&q=London%2Cuk");
            WebRequest webRequest = WebRequest.Create(url);

            //string authHeader = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("5037d509" + ":" + "4dc1aebaa63721f0f8e79a55e2514bc7"));
            webRequest.Headers.Add("X-RapidAPI-Host", "community-open-weather-map.p.rapidapi.com");
            webRequest.Headers.Add("X-RapidAPI-Key", "c10a554e76msh302d6c68a43eabcp19891bjsn49070d6fb2b9");

            webRequest.Method = "GET";
            HttpWebResponse httpResponse = null;
            httpResponse = (HttpWebResponse)webRequest.GetResponse();

            string result = null;
            using (Stream stream = httpResponse.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();

            }
            
            return result;
     
        }

    }
}
