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
      private XmlDocument makeRequest(APICredentials credentials, string method, string url)
      {
         HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
         OAuthHeader header = new OAuthHeader(credentials.AppToken, credentials.AppSecret, credentials.AccessToken, credentials.AccessSecret);
         request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
         request.Method = method;

         HttpWebResponse response = request.GetResponse() as HttpWebResponse;
         XmlDocument doc = new XmlDocument();
         doc.Load(response.GetResponseStream());
         return doc;
      }

      public XmlDocument OrderRequest(APICredentials credentials, int actor, int state, int start = 0)
      {
         string url = String.Concat("https://www.mkmapi.eu/ws/v2.0/orders/", actor.ToString(), "/", state.ToString());

         if (start > 0)
         {
            url = String.Concat(url, "/", start.ToString());
         }

         return orderRequest(credentials, url);
      }
      public XmlDocument OrderRequest(APICredentials credentials, string actor, string state, int start = 0)
      {
         string url = String.Concat("https://www.mkmapi.eu/ws/v2.0/orders/", actor, "/", state);

         if (start > 0)
         {
            url = String.Concat(url, "/", start.ToString());
         }

         return orderRequest(credentials, url);
      }
      private XmlDocument orderRequest(APICredentials credentials, string url)
      {
         String method = "GET";
         return makeRequest(credentials, method, url);
      }
   }
}
