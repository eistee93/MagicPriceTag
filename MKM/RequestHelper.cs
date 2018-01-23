using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MKM
{
   public class RequestHelper
   {
      public string makeRequest(APICredentials credentials)
      {
         String method = "GET";
         String url = "https://www.mkmapi.eu/ws/v2.0/account";

         HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
         OAuthHeader header = new OAuthHeader(credentials.AppToken, credentials.AppSecret, credentials.AccessToken, credentials.AccessSecret);
         request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
         request.Method = method;

         HttpWebResponse response = request.GetResponse() as HttpWebResponse;
         XmlDocument doc = new XmlDocument();
         doc.Load(response.GetResponseStream());
         // proceed further
         return doc.InnerText;
      }
   }
}
