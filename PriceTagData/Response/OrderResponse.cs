using System;

namespace PriceTagData.Response
{
   [Serializable()]
   [System.Xml.Serialization.XmlRoot("response")]
   public class OrderResponse
   {
      [System.Xml.Serialization.XmlElement("order")]
      public Order[] Orders { get; set; }
   }
}
