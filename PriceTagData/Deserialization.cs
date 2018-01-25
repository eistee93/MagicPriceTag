using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PriceTagData
{
   public static class Deserialization
   {
      public static Response.OrderResponse DeserializeOrderResponse(XmlDocument xdoc)
      {
         using (XmlReader reader = XmlReader.Create(new StringReader(xdoc.OuterXml)))
         {
            reader.MoveToContent();
            switch (reader.Name)
            {
               case "response":
                  return (Response.OrderResponse)new XmlSerializer(typeof(Response.OrderResponse)).Deserialize(reader);
               default:
                  throw new NotSupportedException("Unexpected: " + reader.Name);
            }
         }
      }
   }
}
