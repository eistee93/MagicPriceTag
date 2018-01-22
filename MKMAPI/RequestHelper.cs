﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace MKMAPI
{
    class RequestHelper
    {
      public void makeRequest()
      {
         String method = "GET";
         String url = "https://www.mkmapi.eu/ws/v2.0/account";

         HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
         OAuthHeader header = new OAuthHeader();
         request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
         request.Method = method;

         HttpWebResponse response = request.GetResponse() as HttpWebResponse;
         XmlDocument doc = new XmlDocument();
         doc.Load(response.GetResponseStream());
         // proceed further
      }
   }
}