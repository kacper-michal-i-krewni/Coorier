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
            string url = String.Format("https://api.spotify.com/v1/albums/1/tracks");
            WebRequest webRequest = WebRequest.Create(url);
           
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
